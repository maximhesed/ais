using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAddGood : Form
    {
        private readonly SqlCommand cmd;

        public frmAddGood(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;

            if (Utils.GetOrdReqs(cmd, this.cmbOrdReqs) == 0) {
                MessageBox.Show("No order requests available.");

                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string ordid = this.cmbOrdReqs.Text.Split(' ')[0];

            this.cmd.CommandText =
                "select id " +
                "   from stock " +
                "       where ordid = " + ordid;

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                if (r.Read()) {
                    MessageBox.Show("This order is already received.");

                    return;
                }
            }

            this.cmd.CommandText = "AddGood";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@ordid", ordid);
            this.cmd.Parameters.AddWithValue("@rec_date", this.dtpReceive.Value.ToShortDateString());

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

