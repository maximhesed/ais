using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ais
{
    public partial class frmAddLead : Form
    {
        private readonly SqlCommand cmd;

        public frmAddLead(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            TransportData.LeadData leadData = new TransportData.LeadData {
                firstName = this.txtNameFirst,
                lastName = this.txtNameLast,
                patronymic = this.txtPatronymic,
                email = this.txtEmail,
                phone = this.txtPhone,
                promTime = this.txtPromTime
            };

            if (!Utils.CheckLeadData(leadData))
                return;

            this.cmd.CommandText = "AddLead";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@name_first", this.txtNameFirst.Text);
            this.cmd.Parameters.AddWithValue("@name_last", this.txtNameLast.Text);
            this.cmd.Parameters.AddWithValue("@patronymic", this.txtPatronymic.Text);
            this.cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
            this.cmd.Parameters.AddWithValue("@phone", this.txtPhone.Text);
            this.cmd.Parameters.AddWithValue("@prom_time", this.txtPromTime.Text);
            this.cmd.Parameters.AddWithValue("@appeal_date", this.dtpAppeal.Value.ToShortDateString());

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

