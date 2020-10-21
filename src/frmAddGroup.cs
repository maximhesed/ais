using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAddGroup : Form
    {
        private readonly SqlCommand cmd;

        public frmAddGroup(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;

            if (Utils.GetEmployees(cmd, "Producer", this.cmbProducers) == 0) {
                MessageBox.Show("No producers available.");

                Close();
            }

            if (Utils.GetEmployees(cmd, "Artist designer", this.cmbArtists) == 0) {
                MessageBox.Show("No artist designers available.");

                Close();
            }

            if (Utils.GetEmployees(cmd, "Graphics specialist", this.cmbGraphics) == 0) {
                MessageBox.Show("No graphics specialists available.");

                Close();
            }

            if (Utils.GetEmployees(cmd, "Copywriter", this.cmbCopywriters) == 0) {
                MessageBox.Show("No copywriters available.");

                Close();
            }

            if (Utils.GetLeads(cmd, this.cmbLeads) == 0) {
                MessageBox.Show("No leads available.");

                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int promTime;
            string lid = this.cmbLeads.Text.Split(' ')[0];

            this.cmd.CommandText =
                "select id " +
                "   from groups " +
                "       where lid = " + lid;

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                if (r.Read()) {
                    MessageBox.Show("This lead is already taken.");

                    return;
                }
            }

            this.cmd.CommandText =
                "select prom_time " +
                "   from leads " +
                "       where id = " + lid;

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                r.Read();

                promTime = Convert.ToInt32(r[0]);
            }

            this.cmd.CommandText = "AddGroup";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@pid", this.cmbProducers.Text.Split(' ')[0]);
            this.cmd.Parameters.AddWithValue("@adid", this.cmbArtists.Text.Split(' ')[0]);
            this.cmd.Parameters.AddWithValue("@gsid", this.cmbGraphics.Text.Split(' ')[0]);
            this.cmd.Parameters.AddWithValue("@cid", this.cmbCopywriters.Text.Split(' ')[0]);
            this.cmd.Parameters.AddWithValue("@comp_date", this.dtpCompletion.Value.ToShortDateString());
            this.cmd.Parameters.AddWithValue("@lid", lid);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

