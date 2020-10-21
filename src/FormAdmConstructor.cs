using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ais
{
    public class FormAdmConstructor
    {
        private struct GroupsData
        {
            internal string id;
            internal string comp_date;
            internal string pid;
            internal string adid;
            internal string gsid;
            internal string cid;
            internal string lid;
        }

        private struct StockData
        {
            internal string id;
            internal string ordid;
            internal string rec_date;
        }

        internal TabControl tbc = new TabControl();
        internal MenuStrip mns = new MenuStrip();
        private readonly TabPage tabEmployees = new TabPage();
        private readonly TabPage tabLeads = new TabPage();
        private readonly TabPage tabGroups = new TabPage();
        private readonly TabPage tabOrdReqs = new TabPage();
        private readonly TabPage tabContractors = new TabPage();
        private readonly TabPage tabStock = new TabPage();
        private readonly ListBox lstEmployees = new ListBox();
        private readonly ListBox lstLeads = new ListBox();
        private readonly ListBox lstGroups = new ListBox();
        private readonly ListBox lstOrdReqs = new ListBox();
        private readonly ListBox lstContractors = new ListBox();
        private readonly ListBox lstStock = new ListBox();
        internal readonly ComboBox cmbContractors = new ComboBox();
        private string lstSelName;
        private readonly List<string> lstSelItems = new List<string>();
        private readonly ContextMenuStrip cms;
        private readonly SqlCommand cmd;
        private readonly List<string> fields = new List<string>();
        internal string[] contractorsEnabled;
        private readonly string email;
        private readonly List<TransportData.ListMenu> lstMenu = new List<TransportData.ListMenu>();
        private IEnumerator<string> selector;
        private string conjunctionalDepartment = null;
        internal TextBox searchBox = new TextBox();

        public FormAdmConstructor(SqlCommand cmd, string email) {
            this.cmd = cmd;
            this.email = email;

            this.tbc.Location = new Point(1, 24);
            this.tbc.Size = new Size(0, 368);
            this.tbc.Font = new Font("Lucida Console", 8f);

            this.mns.Size = new Size(527, 24);

            this.searchBox.Size = new Size(100, 24);

            this.lstLeads.ContextMenuStrip = this.lstContractors.ContextMenuStrip
                = this.lstEmployees.ContextMenuStrip = this.cms = new ContextMenuStrip();
            this.cms.Opening += new CancelEventHandler(cms_Opening);
            this.cms.ItemClicked += new ToolStripItemClickedEventHandler(cms_ItemClicked);
        }

        /* --- Unilateral switches. --- */

        internal void EnableMenuAdd(string[] subitems) {
            ToolStripMenuItem itemAdd = new ToolStripMenuItem("Add");

            foreach (string subitem in subitems) {
                ToolStripMenuItem item = new ToolStripMenuItem(subitem);

                item.Click += new EventHandler(MenuAddItemHandler);
                itemAdd.DropDownItems.Add(item);
            }

            this.mns.Items.Add(itemAdd);
        }

        internal void EnableEmployees(string conjunctionalDepartment = "") {
            if (!string.IsNullOrEmpty(conjunctionalDepartment))
                this.conjunctionalDepartment = conjunctionalDepartment;

            SetupTab(this.tabEmployees, "Employees", "tabEmployees");
            SetupList(this.lstEmployees, "lstEmployees", new Point(0, 0));

            this.tabEmployees.Controls.Add(this.lstEmployees);

            this.tbc.TabPages.Add(this.tabEmployees);
        }

        internal void EnableLeads() {
            SetupTab(this.tabLeads, "Leads", "tabLeads");
            SetupList(this.lstLeads, "lstLeads", new Point(0, 0));

            this.tabLeads.Controls.Add(this.lstLeads);

            this.tbc.TabPages.Add(this.tabLeads);
        }

        internal void EnableGroups() {
            SetupTab(this.tabGroups, "Groups", "tabGroups");
            SetupList(this.lstGroups, "lstGroups", new Point(0, 0));

            this.tabGroups.Controls.Add(this.lstGroups);

            this.tbc.TabPages.Add(this.tabGroups);
        }

        internal void EnableOrdReqs() {
            SetupTab(this.tabOrdReqs, "Order requests", "tabOrdReqs");
            SetupList(this.lstOrdReqs, "lstOrdReqs", new Point(0, 0));

            this.tabOrdReqs.Controls.Add(this.lstOrdReqs);

            this.tbc.TabPages.Add(this.tabOrdReqs);
        }

        internal void EnableContractors(string[] departments) {
            this.contractorsEnabled = departments;

            SetupTab(this.tabContractors, "Contractors", "tabContractors");

            if (departments.Length > 1) {
                SetupCmbContractors(this.cmbContractors, departments);
                SetupList(this.lstContractors, "lstContractors", new Point(0, 22), new Size(518, 323));

                this.tabContractors.Controls.Add(this.cmbContractors);
            }
            else
                SetupList(this.lstContractors, "lstContractors", new Point(0, 0));

            this.tabContractors.Controls.Add(this.lstContractors);

            this.tbc.TabPages.Add(this.tabContractors);
        }

        internal void EnableStock() {
            SetupTab(this.tabStock, "Stock", "tabStock");
            SetupList(this.lstStock, "lstStock", new Point(0, 0));

            this.tabStock.Controls.Add(this.lstStock);

            this.tbc.TabPages.Add(this.tabStock);
        }

        private void SetupTab(TabPage tab, string text, string name) {
            tab.Text = text;
            tab.Name = name;
            tab.Location = new Point(4, 21);
            tab.Padding = new Padding(3);
        }

        private void SetupCmbContractors(ComboBox cmb, string[] contractors) {
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string c in contractors)
                cmb.Items.Add(c);
            cmb.SelectedIndex = 0;
            cmb.Font = new Font("Lucida Console", 8f);
            cmb.Location = new Point(0, 1);
            cmb.Margin = new Padding(3);
            cmb.SelectedIndexChanged += new EventHandler(cmbContractors_SelectedIndexChanged);
        }

        private void SetupList(ListBox lst, string name, Point location, Size? size = null) {
            lst.Name = name;
            lst.DrawMode = DrawMode.OwnerDrawFixed;
            lst.Font = new Font("Lucida Console", 8f);
            lst.Location = location;
            lst.Size = size ?? new Size(518, 345);
            lst.Margin = new Padding(3);
            lst.IntegralHeight = false;
            lst.ItemHeight = 11;
            lst.SelectionMode = SelectionMode.MultiExtended;
            lst.MouseDown += new MouseEventHandler(lst_MouseDown);
            lst.DrawItem += new DrawItemEventHandler(lst_DrawItem);
        }

        internal void AddContextMenuEntity(string lstName, string[] items) {
            TransportData.ListMenu item = new TransportData.ListMenu {
                lstName = lstName,
                items = items
            };

            this.lstMenu.Add(item);
        }

        /* Is it possible to combine UpdateTab* in an one piece? */
        internal void UpdateTabEmployees() {
            const string format = "| {0, -3} | {1, -50} | {2, -16} | {3, -32} |";

            this.lstEmployees.Items.Clear();
            this.cmd.CommandText =
                "select id, name_last, name_first, patronymic, department, position " +
                "   from employees";

            if (!string.IsNullOrEmpty(this.conjunctionalDepartment))
                this.cmd.CommandText += " where department = '" + this.conjunctionalDepartment + "'";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read()) {
                    this.lstEmployees.Items.Add(string.Format(format,
                        r[0],
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3].ToString()) ? " " + r[3] : ""),
                        r[4],
                        r[5]));
                }
            }

            this.lstEmployees.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 3),
                Utils.CenterString("FULL NAME", 50),
                Utils.CenterString("DEPARTMENT", 16),
                Utils.CenterString("POSITION", 32)));

            FormatTab(this.tabEmployees, this.lstEmployees);
        }

        internal void UpdateTabLeads() {
            const string format = "| {0, -3} | {1, -50} | {2, -48} | {3, -16} |";

            this.lstLeads.Items.Clear();
            this.cmd.CommandText =
                "select id, name_last, name_first, patronymic, email, phone " +
                "   from leads";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read())
                    this.lstLeads.Items.Add(string.Format(format,
                        r[0],
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3].ToString()) ? " " + r[3] : ""),
                        r[4],
                        !string.IsNullOrEmpty(r[5].ToString()) ? r[5] : "<None>"));
            }

            this.lstLeads.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 3),
                Utils.CenterString("FULL NAME", 50),
                Utils.CenterString("EMAIL", 48),
                Utils.CenterString("PHONE", 16)));

            FormatTab(this.tabLeads, this.lstLeads);
        }

        internal void UpdateTabGroups() {
            List<GroupsData> fields = new List<GroupsData>();
            const string format = "| {0, -3} | {1, -16} | {2, -10} | {3, -16} | {4, -16} | {5, -10} | {6, -16} |";

            this.lstGroups.Items.Clear();
            this.cmd.CommandText =
                "select id, comp_date, pid, adid, gsid, cid, lid " +
                "   from groups";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read())
                    fields.Add(new GroupsData {
                        id = r[0] + "",
                        comp_date = ((DateTime) r[1]).ToShortDateString(),
                        pid = r[2] + "",
                        adid = r[3] + "",
                        gsid = r[4] + "",
                        cid = r[5] + "",
                        lid = r[6] + ""
                    });
            }

            foreach (GroupsData f in fields)
                this.lstGroups.Items.Add(string.Format(format,
                    f.id, f.pid, f.adid, f.gsid, f.cid, f.lid, f.comp_date));

            this.lstGroups.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 3),
                Utils.CenterString("PRODUCER ID", 16),
                Utils.CenterString("ARTIST ID", 10),
                Utils.CenterString("GRAPHICS ID", 16),
                Utils.CenterString("COPYWRITER ID", 16),
                Utils.CenterString("LEAD ID", 10),
                Utils.CenterString("COMPLETION DATE", 16)));

            FormatTab(this.tabGroups, this.lstGroups);
        }

        internal void UpdateTabOrdReqs() {
            const string format = "| {0, -19} | {1, -64} | {2, -16} | {3, -16} |";

            this.lstOrdReqs.Items.Clear();
            this.cmd.CommandText =
                "select id, prod_name, prod_quantity, period_date " +
                "   from ord_reqs";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read())
                    this.lstOrdReqs.Items.Add(string.Format(format,
                        r[0],
                        r[1],
                        r[2],
                        ((DateTime) r[3]).ToShortDateString()));
            }

            this.lstOrdReqs.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 19),
                Utils.CenterString("PRODUCT NAME", 64),
                Utils.CenterString("PRODUCT QUANTITY", 16),
                Utils.CenterString("COMPLETION DATE", 16)));

            FormatTab(this.tabOrdReqs, this.lstOrdReqs);
        }

        internal void UpdateTabContractors() {
            const string format = "| {0, -10} | {1, -50} | {2, -16} |";

            this.lstContractors.Items.Clear();
            this.cmd.CommandText =
                "select id, name_last, name_first, patronymic, price" +
                "   from contractors_" + GetSelectedContractor().ToLower();

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read())
                    this.lstContractors.Items.Add(string.Format(format,
                        r[0],
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3].ToString()) ? " " + r[3] : ""),
                        r[4]));
            }

            this.lstContractors.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 10),
                Utils.CenterString("FULL NAME", 50),
                Utils.CenterString("PRICE", 16)));

            FormatTab(this.tabContractors, this.lstContractors);
        }

        internal void UpdateTabStock() {
            List<StockData> fields = new List<StockData>();
            const string format = "| {0, -10} | {1, -64} | {2, -10} | {3, -16} |";

            this.lstStock.Items.Clear();
            this.cmd.CommandText =
                "select id, ordid, rec_date " +
                "   from stock";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                while (r.Read())
                    fields.Add(new StockData {
                        id = r[0] + "",
                        ordid = r[1] + "",
                        rec_date = ((DateTime) r[2]).ToShortDateString()
                    });
            }

            foreach (StockData f in fields) {
                this.cmd.CommandText =
                    "select prod_name, prod_quantity " +
                    "   from ord_reqs        " +
                    "       where id = " + f.ordid;

                using (SqlDataReader r = this.cmd.ExecuteReader()) {
                    r.Read();

                    this.lstStock.Items.Add(string.Format(format,
                        f.id, r[0], r[1], f.rec_date));
                }
            }

            this.lstStock.Items.Insert(0, string.Format(format,
                Utils.CenterString("ID", 10),
                Utils.CenterString("PRODUCT NAME", 64),
                Utils.CenterString("PRICE", 10),
                Utils.CenterString("RECEIVING DATE", 16)));

            FormatTab(this.tabStock, this.lstStock);
        }

        private void FormatTab(TabPage page, ListBox lst) {
            int width;

            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                width = (int) graphics.MeasureString(lst.Items[0].ToString(),
                    new Font("Lucida Console", 8, FontStyle.Regular, GraphicsUnit.Point)).Width + 11;

            lst.Items.Insert(1, new string('-', (lst.Items[0] + "").Length));

            if (lst.Name == "lstContractors")
                this.cmbContractors.Size = new Size(width - 6, 19);

            width += lst.Items.Count > 30 ? 18 : 0;
            lst.Width = width - 6;
            page.Width = width;
            this.tbc.Width = width + 4;

            lst.Items.Insert(lst.Items.Count, new string('-', (lst.Items[0] + "").Length));
        }

        /* --- frmInfo setups. --- */

        private void ShowEmployeeInfo(string id) {
            string firstName;
            string lastName;
            string patronymic;
            string email;
            string phone;
            string department;
            string position;
            string reg_date;

            this.selector = Selector(new string[] {
                "name_first",
                "name_last",
                "patronymic",
                "email",
                "phone",
                "department",
                "position",
                "reg_date" },
                "employees",
                "id " + id);

            firstName = Walker();
            lastName = Walker();
            patronymic = Walker();
            email = Walker();
            phone = Walker();
            department = Walker();
            position = Walker();
            reg_date = DateTime.Parse(Walker()).ToShortDateString();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Full name: " + lastName + " " + firstName + " " + (!string.IsNullOrEmpty(patronymic) ? patronymic : ""));
            this.fields.Add("Email: " + email);
            this.fields.Add("Phone: " + (!string.IsNullOrEmpty(phone) ? phone : "<None>"));
            this.fields.Add("Department: " + department);
            this.fields.Add("Position: " + position);
            this.fields.Add("Registration date: " + reg_date);
            this.fields.Add("Id: " + id);

            frmInfo f = new frmInfo(this.fields, "Employee"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        private void ShowLeadInfo(string id) {
            string firstName;
            string lastName;
            string patronymic;
            string email;
            string phone;
            string promTime;
            string appealDate;

            this.selector = Selector(new string[] {
                "name_first",
                "name_last",
                "patronymic",
                "email",
                "phone",
                "prom_time",
                "appeal_date" },
                "leads",
                "id " + id);

            firstName = Walker();
            lastName = Walker();
            patronymic = Walker();
            email = Walker();
            phone = Walker();
            promTime = Walker();
            appealDate = DateTime.Parse(Walker()).ToShortDateString();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Full name: " + lastName + " " + firstName + " " + (!string.IsNullOrEmpty(patronymic) ? patronymic : ""));
            this.fields.Add("Email: " + email);
            this.fields.Add("Phone: " + (!string.IsNullOrEmpty(phone) ? phone : "<None>"));
            this.fields.Add("Promotional video time: " + promTime);
            this.fields.Add("Appeal date: " + appealDate);
            this.fields.Add("Id: " + id);

            frmInfo f = new frmInfo(this.fields, "Lead"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        private void ShowGroupInfo(string id) {
            string pid;
            string adid;
            string gsid;
            string cid;
            string promTime;
            string compDate;
            string lid;
            string budget;

            this.selector = Selector(new string[] {
                "pid",
                "adid",
                "gsid",
                "cid",
                "comp_date",
                "lid" },
                "groups",
                "id " + id);

            pid = Walker();
            adid = Walker();
            gsid = Walker();
            cid = Walker();
            compDate = DateTime.Parse(Walker()).ToShortDateString();
            lid = Walker();
            this.selector.Dispose();

            this.cmd.CommandText =
                "select prom_time" +
                "   from leads" +
                "       where id = " + lid;

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                r.Read();

                promTime = r[0] + "";
            }

            this.cmd.CommandText =
                "select sum(price)" +
                "   from (" +
                "       select price" +
                "           from contractors_media" +
                "       union all" +
                "       select price" +
                "           from contractors_production" +
                "   ) as budget";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                r.Read();

                budget = r[0] + "";
            }

            this.fields.Clear();
            this.fields.Add("Producer id: " + Utils.GetPersonInfo(this.cmd, "employees", pid));
            this.fields.Add("Artist designer id: " + Utils.GetPersonInfo(this.cmd, "employees", adid));
            this.fields.Add("Graphics specialist id: " + Utils.GetPersonInfo(this.cmd, "employees", gsid));
            this.fields.Add("Copywriter id: " + Utils.GetPersonInfo(this.cmd, "employees", cid));
            this.fields.Add("Promotional video time: " + promTime);
            this.fields.Add("Budget: " + budget);
            this.fields.Add("Completion date: " + compDate);
            this.fields.Add("Served lead id: " + Utils.GetPersonInfo(this.cmd, "leads", lid));

            frmInfo f = new frmInfo(this.fields, "Group"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        private void ShowOrdReqInfo(string id) {
            string prodName;
            string prodQuantity;
            string periodDate;
            string pid;
            string lid;

            this.selector = Selector(new string[] {
                "prod_name",
                "prod_quantity",
                "period_date",
                "pid",
                "lid" },
                "ord_reqs",
                "id " + id);

            prodName = Walker();
            prodQuantity = Walker();
            periodDate = DateTime.Parse(Walker()).ToShortDateString();
            pid = Walker();
            lid = Walker();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Product name: " + prodName);
            this.fields.Add("Product quantity: " + prodQuantity);
            this.fields.Add("Period date: " + periodDate);
            this.fields.Add("Producer id: " + Utils.GetPersonInfo(this.cmd, "employees", pid));
            this.fields.Add("Served lead id: " + Utils.GetPersonInfo(this.cmd, "leads", lid));
            this.fields.Add("Order request id: " + id);

            frmInfo f = new frmInfo(this.fields, "Order request"); // will be closed anyway (no need to dispose)

            f.ShowDialog();
        }

        private void ShowContractorMediaInfo(string id) {
            string firstName;
            string lastName;
            string patronymic;
            string email;
            string phone;
            string price;
            string timestamps;
            string lid;

            this.selector = Selector(new string[] {
                "name_first",
                "name_last",
                "patronymic",
                "email",
                "phone",
                "price",
                "timestamps",
                "lid" },
                "contractors_media",
                "id " + id);

            firstName = Walker();
            lastName = Walker();
            patronymic = Walker();
            email = Walker();
            phone = Walker();
            price = Walker();
            timestamps = Walker();
            lid = Walker();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Full name: " + lastName + " " + firstName + " " + (!string.IsNullOrEmpty(patronymic) ? patronymic : ""));
            this.fields.Add("Email: " + email);
            this.fields.Add("Phone: " + (!string.IsNullOrEmpty(phone) ? phone : "<None>"));
            this.fields.Add("Price: " + price);
            if (!string.IsNullOrEmpty(timestamps))
                this.fields.Add("Timestamps: " + timestamps);
            this.fields.Add("Served lead id: " + Utils.GetPersonInfo(this.cmd, "leads", lid));

            frmInfo f = new frmInfo(this.fields, "Media contractor"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        private void ShowContractorProductionInfo(string id) {
            string firstName;
            string lastName;
            string patronymic;
            string email;
            string phone;
            string ordid; // -------------+
            string price;          //     |
                                   //     |
            string prodName;       // ]   |
            string prodQuantity;   // ]   |
            string periodDate;     // ] <-+
            string pid;            // ]
            string lid;            // ]

            this.selector = Selector(new string[] {
                "name_first",
                "name_last",
                "patronymic",
                "email",
                "phone",
                "ordid",
                "price" },
                "contractors_production",
                "id " + id);

            firstName = Walker();
            lastName = Walker();
            patronymic = Walker();
            email = Walker();
            phone = Walker();
            ordid = Walker();
            price = Walker();
            this.selector.Dispose();

            this.selector = Selector(new string[] {
                "prod_name",
                "prod_quantity",
                "period_date",
                "pid",
                "lid" },
                "ord_reqs",
                "id " + ordid);

            prodName = Walker();
            prodQuantity = Walker();
            periodDate = DateTime.Parse(Walker()).ToShortDateString();
            pid = Walker();
            lid = Walker();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Full name: " + lastName + " " + firstName + " " + (!string.IsNullOrEmpty(patronymic) ? patronymic : ""));
            this.fields.Add("Email: " + email);
            this.fields.Add("Phone: " + (!string.IsNullOrEmpty(phone) ? phone : "<None>"));
            this.fields.Add("Product name: " + prodName);
            this.fields.Add("Products quantity: " + prodQuantity);
            this.fields.Add("Price: " + price);
            this.fields.Add("Producer id: " + Utils.GetPersonInfo(this.cmd, "employees", pid));
            this.fields.Add("Served lead id: " + Utils.GetPersonInfo(this.cmd, "leads", lid));
            this.fields.Add("Period date: " + periodDate);

            frmInfo f = new frmInfo(this.fields, "Production contractor"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        private void ShowGoodInfo(string id) {
            string ordid; // -------------+
            string rec_date;       //     |
                                   //     |
            string prodName;       // ]   |
            string prodQuantity;   // ] <-+
            string pid;            // ]
            string lid;            // ]

            this.selector = Selector(new string[] {
                "ordid",
                "rec_date" },
                "stock",
                "id " + id);

            ordid = Walker();
            rec_date = DateTime.Parse(Walker()).ToShortDateString();
            this.selector.Dispose();

            this.selector = Selector(new string[] {
                "prod_name",
                "prod_quantity",
                "pid",
                "lid" },
                "ord_reqs",
                "id " + ordid);

            prodName = Walker();
            prodQuantity = Walker();
            pid = Walker();
            lid = Walker();
            this.selector.Dispose();

            this.fields.Clear();
            this.fields.Add("Product name: " + prodName);
            this.fields.Add("Product quantity: " + prodQuantity);
            this.fields.Add("Producer id: " + Utils.GetPersonInfo(this.cmd, "employees", pid));
            this.fields.Add("Served lead id: " + Utils.GetPersonInfo(this.cmd, "leads", lid));
            this.fields.Add("Order request id: " + ordid);
            this.fields.Add("Receiving date: " + rec_date);

            frmInfo f = new frmInfo(this.fields, "Good"); // will be closed anyway (no need to dispose)

            f.Show();
        }

        /* --- Non-list menu actions. --- */

        private void AddEmployee() {
            using (frmAddEmployee f = new frmAddEmployee(this.cmd)) {
                if (!f.IsDisposed)
                    f.ShowDialog();
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabEmployees();
        }

        private void AddLead() {
            using (frmAddLead f = new frmAddLead(this.cmd)) {
                if (!f.IsDisposed)
                    f.ShowDialog();
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabLeads();
        }

        private void AddGroup() {
            using (frmAddGroup f = new frmAddGroup(this.cmd)) {
                if (!f.IsDisposed)
                    f.ShowDialog();
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabGroups();
        }

        private void AddOrdReq() {
            using (frmAddOrdReq f = new frmAddOrdReq(this.cmd, this.email)) {
                if (!f.IsDisposed)
                    f.ShowDialog();
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabOrdReqs();
        }

        private void AddContractor() {
            switch (GetSelectedContractor()) {
                case "contractors_media":
                    using (frmAddContractorMedia f = new frmAddContractorMedia(this.cmd)) {
                        if (!f.IsDisposed)
                            f.ShowDialog();
                    }

                    break;

                case "contractors_production":
                    using (frmAddContractorProduction f = new frmAddContractorProduction(this.cmd)) {
                        if (!f.IsDisposed)
                            f.ShowDialog();
                    }

                    break;
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabContractors();
        }

        private void AddGood() {
            using (frmAddGood f = new frmAddGood(this.cmd)) {
                if (!f.IsDisposed)
                    f.ShowDialog();
            }

            this.cmd.CommandType = CommandType.Text;

            UpdateTabStock();
        }

        private void Remove(ListBox lst) {
            string tableName = ConvertListNameToTableName(lst.Name);

            if (MessageBox.Show("Are you sure about that?", "", MessageBoxButtons.YesNo)
                    == DialogResult.Yes) {
                int rowsAffected = 0;

                switch (tableName) {
                    case "leads":
                        if (MessageBox.Show("The columns with the lead id-s, you selected, will be DELETED from the next tables: " +
                                "'groups', 'ord_reqs', 'contractors_media'. Also, because 'ord_reqs' table will be affected, " +
                                "the columns with the order request id-s will be DELETED from the next tables: " +
                                "'contractors_production', 'stock'.", "Cascade deletion",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;

                        break;

                    case "ord_reqs":
                        if (MessageBox.Show("The columns with the order request id-s, you selected, will be DELETED from the " +
                                "next tables: 'contractors_production', 'stock'.", "Cascade deletion",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;

                        break;
                }

                foreach (int index in lst.SelectedIndices) {
                    if (tableName == "employees" && index == 2) {
                        MessageBox.Show("The first row willn't be affected, because you can't remove yourself.");

                        continue;
                    }

                    this.cmd.CommandText =
                        "delete" +
                        "   from " + tableName +
                        "       where id = " + (lst.Items[index] + "").Split(' ')[1];

                    rowsAffected += this.cmd.ExecuteNonQuery();
                }

                MessageBox.Show(rowsAffected + " rows affected.");
            }

            switch (tableName) {
                case "employees":
                    UpdateTabEmployees();

                    break;

                case "leads":
                    UpdateTabLeads();

                    break;

                case "groups":
                    UpdateTabGroups();

                    break;

                case "ord_reqs":
                    UpdateTabOrdReqs();

                    break;

                case "contractors_media":
                case "contractors_production":
                    UpdateTabContractors();

                    break;

                case "stock":
                    UpdateTabStock();

                    break;
            }
        }

        /* --- Controls events. --- */

        private void cmbContractors_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateTabContractors();
        }

        private void lst_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ListBox lst = sender as ListBox;

                this.lstSelItems.Clear();

                if (lst.SelectedIndices.Count - 1 == 0) {
                    if (new List<int> { 0, 1, lst.Items.Count - 1 }.Contains(lst.SelectedIndex))
                        lst.SelectedIndex = -1;
                    else
                        this.lstSelItems.Add(lst.Items[lst.SelectedIndex] + "");
                }
                else {
                    for (int i = lst.SelectedIndices.Count - 1; i >= 0; i--) {
                        if (new List<int> { 0, 1, lst.Items.Count - 1 }.Contains(lst.SelectedIndices[i]))
                            lst.SelectedIndices.Remove(i);
                        else
                            this.lstSelItems.Add(lst.Items[lst.SelectedIndices[i]] + "");
                    }
                }

                if (this.lstSelItems.Count == 0)
                    return;

                this.lstSelName = lst.Name;
                this.cms.Show(Cursor.Position);
            }
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e) {
            ListBox lst = sender as ListBox;

            if (e.Index >= 0) {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e = new DrawItemEventArgs(
                        e.Graphics,
                        e.Font,
                        e.Bounds,
                        e.Index,
                        e.State ^ DrawItemState.Selected,
                        e.ForeColor,
                        Color.LightGray);

                e.DrawBackground();
                e.Graphics.DrawString(
                    lst.Items[e.Index].ToString(),
                    e.Font,
                    Brushes.Black,
                    e.Bounds,
                    StringFormat.GenericDefault);
            }
        }

        private void cms_Opening(object sender, CancelEventArgs e) {
            if (this.lstSelItems.Count == 0 || !this.lstMenu.Exists(item => item.lstName == this.lstSelName))
                e.Cancel = true;

            this.cms.Items.Clear();

            AddListCmsItems(this.lstSelName);
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string cmsItem = e.ClickedItem.ToString();

            ((ContextMenuStrip) sender).Close();

            if (cmsItem.Contains("Show")) {
                foreach (string item in this.lstSelItems) {
                    string id = item.Split(' ')[1];

                    switch (ConvertListNameToTableName(this.lstSelName)) {
                        case "employees":
                            ShowEmployeeInfo(id);

                            break;

                        case "leads":
                            ShowLeadInfo(id);

                            break;

                        case "groups":
                            ShowGroupInfo(id);

                            break;

                        case "ord_reqs":
                            ShowOrdReqInfo(id);

                            break;

                        case "contractors_media":
                            ShowContractorMediaInfo(id);

                            break;

                        case "contractors_production":
                            ShowContractorProductionInfo(id);

                            break;

                        case "lstStock":
                            ShowGoodInfo(id);

                            break;
                    }
                }
            }
            else if (cmsItem.Contains("Remove"))
                Remove(GetCurrList());
        }

        private void AddListCmsItems(string lstName) {
            string entityName = "";

            switch (lstName) {
                case "lstEmployees":
                    entityName = "employee";

                    break;

                case "lstLeads":
                    entityName = "lead";

                    break;

                case "lstGroups":
                    entityName = "group";

                    break;

                case "lstOrdReqs":
                    entityName = "order request";

                    break;

                case "lstContractors":
                    entityName = "contractor";

                    break;

                case "lstStock":
                    entityName = "good";

                    break;
            }

            foreach (TransportData.ListMenu menu in this.lstMenu) {
                if (menu.lstName == lstName) {
                    foreach (string item in menu.items) {
                        switch (item) {
                            case "info":
                                this.cms.Items.Add("Show " + entityName + " info");

                                break;

                            case "remove":
                                this.cms.Items.Add("Remove " + entityName);

                                break;
                        }
                    }
                }
            }
        }

        private void MenuAddItemHandler(object sender, EventArgs e) {
            switch (((ToolStripMenuItem) sender).Text) {
                case "Employee":
                    AddEmployee();

                    break;

                case "Lead":
                    AddLead();

                    break;

                case "Group":
                    AddGroup();

                    break;

                case "Order request":
                    AddOrdReq();

                    break;

                case "Contractor":
                    AddContractor();

                    break;

                case "Good":
                    AddGood();

                    break;
            }
        }

        /* Simple SQL selector, with optional predicate.
         * Predicate format: field value (e. g.: 'id 14', 'price 120000'). */
        private IEnumerator<string> Selector(string[] fields, string tableName, string predicate = "") {
            string cmd = "select ";

            foreach (string f in fields)
                cmd += f + ", ";

            cmd = cmd.Remove(cmd.Length - 2, 2) + " from " + tableName;

            if (!string.IsNullOrEmpty(predicate))
                cmd += " where " + predicate.Split(' ')[0] + " = '" + predicate.Split(' ')[1] + "'";

            this.cmd.CommandText = cmd;

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                r.Read();

                for (int i = 0; i < r.FieldCount; i++)
                    yield return r[i] + "";
            }
        }

        private string Walker() {
            this.selector.MoveNext();

            return this.selector.Current;
        }

        internal ListBox GetCurrList() {
            switch (this.tbc.SelectedTab.Text) {
                case "Employees":
                    return this.lstEmployees;

                case "Leads":
                    return this.lstLeads;

                case "Groups":
                    return this.lstGroups;

                case "Order requests":
                    return this.lstOrdReqs;

                case "Contractors":
                    return this.lstContractors;

                case "Stock":
                    return this.lstStock;
            }

            return null;
        }

        private string ConvertListNameToTableName(string name) {
            string interimName = name.Remove(0, 3);
            string tableName = interimName;

            for (int i = 0; i < interimName.Length; i++) {
                if (char.IsUpper(interimName[i]) && i > 0)
                    tableName = interimName.Insert(i, "_");
            }

            if (tableName == "Contractors")
                tableName += "_" + GetSelectedContractor().ToLower();

            return tableName.ToLower();
        }

        private string GetSelectedContractor() {
            return this.contractorsEnabled.Length > 1 ? this.cmbContractors.Text : this.contractorsEnabled[0];
        }
    }
}