using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ais
{
    public partial class frmAddOrdReq : Form
    {
        private readonly SqlCommand cmd;
        private readonly string email;

        public frmAddOrdReq(SqlCommand cmd, string email) {
            InitializeComponent();

            this.cmd = cmd;
            this.email = email;

            if (Utils.GetLeads(cmd, this.cmbLeads) == 0) {
                MessageBox.Show("No leads available.");

                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string pid;

            TransportData.OrdReqData ordReqData = new TransportData.OrdReqData {
                prodName = this.txtProductName,
                prodQuantity = this.txtProductQuantity
            };

            if (!Utils.CheckOrdReqData(ordReqData))
                return;

            this.cmd.CommandText =
                "select id " +
                "   from employees " +
                "       where email = '" + this.email + "'";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                r.Read();

                pid = r[0].ToString();
            }

            this.cmd.CommandText = "AddOrdReq";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@prod_name", this.txtProductName.Text);
            this.cmd.Parameters.AddWithValue("@prod_quantity", this.txtProductQuantity.Text);
            this.cmd.Parameters.AddWithValue("@period_date", this.dtpPeriod.Value.ToShortDateString());
            this.cmd.Parameters.AddWithValue("@pid", pid);
            this.cmd.Parameters.AddWithValue("@lid", this.cmbLeads.Text.Split(' ')[0]);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

