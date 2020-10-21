using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAuth : Form
    {
        private readonly string con_str = null;
        private const uint WM_NCHITTEST = 0x84;
        private const int HTCLOSE = 0x14;

        public frmAuth() {
            InitializeComponent();

            this.con_str = ReadConfig();

            using (SqlConnection con = new SqlConnection(this.con_str))
            using (SqlCommand cmd = new SqlCommand()) {
                try {
                    con.Open();
                } catch (SqlException ex) {
                    MessageBox.Show((ex + "").Split('\n')[0]);

                    Environment.Exit(-1);
                }

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "select id " +
                    "   from employees";

                using (SqlDataReader r = cmd.ExecuteReader()) {
                    if (!r.HasRows) {
                        r.Close();
                        
                        using (frmFirstUse f = new frmFirstUse(cmd)) {
                            f.FormClosing += delegate {
                                /* This is better than checking a literal. */

                                if (SendMessage(f.Handle, WM_NCHITTEST, 0, 
                                        (int) ((ushort) Cursor.Position.X | (uint) (Cursor.Position.Y << 16))) 
                                        == HTCLOSE)
                                    Environment.Exit(-1);
                            };

                            f.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.txtEmail.Text)) {
                MessageBox.Show("Enter your email.");

                this.txtEmail.Focus();

                return;
            }

            if (string.IsNullOrEmpty(this.txtPassw.Text)) {
                MessageBox.Show("Enter your password.");

                this.txtPassw.Focus();

                return;
            }

            using (SqlConnection con = new SqlConnection(this.con_str))
            using (SqlCommand cmd = new SqlCommand()) {
                string department;
                string position;
                FormAdmConstructor constructor;
                bool isDisenfranchised = false;

                con.Open();

                cmd.Connection = con;
                cmd.CommandText =
                    "select email, password_hash, department, position " +
                    "   from employees " +
                    "       where email = '" + this.txtEmail.Text + "'";

                using (SqlDataReader r = cmd.ExecuteReader()) {
                    if (!r.Read()) {
                        MessageBox.Show("No such user exists.");

                        return;
                    }

                    if (!Utils.CompHash(this.txtPassw.Text, r[1] + "")) {
                        MessageBox.Show("Failed to log in.");

                        return;
                    }

                    department = r[2] + "";
                    position = r[3] + "";
                }

                constructor = new FormAdmConstructor(cmd, this.txtEmail.Text);

                switch (department) {
                    case "Administrative":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees();
                                constructor.EnableLeads();
                                constructor.EnableGroups();
                                constructor.EnableOrdReqs();
                                constructor.EnableContractors(new string[] { "Media", "Production" });
                                constructor.EnableStock();
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info", "remove" });
                                constructor.AddContextMenuEntity("lstLeads", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstGroups", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstOrdReqs", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstContractors", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstStock", new string[] { "info" });
                                constructor.EnableMenuAdd(new string[] { "Employee" });

                                break;
                        }

                        break;

                    case "Lead service":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees("Lead service");
                                constructor.EnableLeads();
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstLeads", new string[] { "info" });

                                break;

                            case "Senior manager":
                                constructor.EnableLeads();
                                constructor.AddContextMenuEntity("lstLeads", new string[] { "info", "remove" });
                                constructor.EnableMenuAdd(new string[] { "Lead" });

                                break;

                            default:
                                isDisenfranchised = true;

                                break;
                        }

                        break;

                    case "Creative":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees("Creative");
                                constructor.EnableGroups();
                                constructor.EnableOrdReqs();
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstOrdReqs", new string[] { "info" });

                                break;

                            case "General producer":
                                constructor.EnableGroups();
                                constructor.EnableOrdReqs();
                                constructor.AddContextMenuEntity("lstGroups", new string[] { "info", "remove" });
                                constructor.AddContextMenuEntity("lstOrdReqs", new string[] { "info", "remove" });
                                constructor.EnableMenuAdd(new string[] { "Group", "Order request" });

                                break;

                            default:
                                isDisenfranchised = true;

                                break;
                        }

                        break;

                    case "Media":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees("Media");
                                constructor.EnableContractors(new string[] { "Media" });
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstContractors", new string[] { "info" });

                                break;

                            case "Media buyer specialist":
                                constructor.EnableContractors(new string[] { "Media" });
                                constructor.AddContextMenuEntity("lstContractors", new string[] { "info", "remove" });
                                constructor.EnableMenuAdd(new string[] { "Contractor" });

                                break;

                            default:
                                isDisenfranchised = true;

                                break;
                        }

                        break;

                    case "Production":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees("Production");
                                constructor.EnableContractors(new string[] { "Production" });
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstContractors", new string[] { "info" });

                                break;

                            case "Senior manager":
                                constructor.EnableContractors(new string[] { "Production" });
                                constructor.AddContextMenuEntity("lstContractors", new string[] { "info", "remove" });
                                constructor.EnableMenuAdd(new string[] { "Contractor" });

                                break;

                            case "Manager":
                                constructor.EnableOrdReqs();
                                constructor.AddContextMenuEntity("lstOrdReqs", new string[] { "info" });

                                break;

                            default:
                                isDisenfranchised = true;

                                break;
                        }

                        break;

                    case "Courier":
                        switch (position) {
                            case "Director":
                                constructor.EnableEmployees("Courier");
                                constructor.EnableStock();
                                constructor.AddContextMenuEntity("lstEmployees", new string[] { "info" });
                                constructor.AddContextMenuEntity("lstStock", new string[] { "info" });

                                break;

                            case "Senior manager":
                                constructor.EnableStock();
                                constructor.AddContextMenuEntity("lstStock", new string[] { "info", "remove" });
                                constructor.EnableMenuAdd(new string[] { "Good" });

                                break;

                            case "Manager":
                                constructor.EnableStock();
                                constructor.AddContextMenuEntity("lstStock", new string[] { "info" });

                                break;

                            default:
                                isDisenfranchised = true;

                                break;
                        }

                        break;
                }

                if (!isDisenfranchised) {
                    using (frmAdm f = new frmAdm(constructor)) {
                        f.Text = this.txtEmail.Text + " (" + department + " department -> " + position + ")";
                        f.FormClosing += delegate {
                            this.txtEmail.Text = "";
                            this.txtPassw.Text = "";

                            Show();
                        };

                        Hide();
                        f.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("You don't have the minimum rights to use AIS. " +
                        "If it isn't, contact AIS support.");
            }
        }

        private string ReadConfig() {
            string[] lines;
            List<string> keys = new List<string>();

            void Assert(string str, string msg = "The configuration file is corrupted.") {
                if (str == null) {
                    MessageBox.Show(msg, "Configuration fault",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Environment.Exit(-1);
                }
            }

            string GetKeyValue(string key) {
                string key_ex;
                string value;

                Assert(key_ex = keys.Find(k => k.Contains(key + "=")));
                Assert(value = key_ex.Split('=')[1]);

                return value;
            }

            if (!File.Exists("config")) {
                MessageBox.Show("Couldn't find the configuration file.",
                    "Configuration fault", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(-1);
            }

            lines = File.ReadAllLines("config");
            if (lines.Length == 0) {
                MessageBox.Show("The configuration file is empty.",
                    "Configuration fault", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(-1);
            }

            foreach (string key in lines)
                keys.Add(key);

            return
                "Server=" + GetKeyValue("Server") + "; " +
                "Database=" + GetKeyValue("Database") + "; " +
                "Integrated Security=yes";
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
    }
}

