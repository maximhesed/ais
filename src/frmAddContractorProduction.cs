using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAddContractorProduction : Form
    {
        private readonly SqlCommand cmd;

        public frmAddContractorProduction(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;

            if (Utils.GetOrdReqs(cmd, this.cmbOrdReqs) == 0) {
                MessageBox.Show("No order requests available.");

                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            TransportData.ContractorData contractorData = new TransportData.ContractorData {
                firstName = this.txtNameFirst,
                lastName = this.txtNameLast,
                patronymic = this.txtPatronymic,
                email = this.txtEmail,
                phone = this.txtPhone,
                price = this.txtPrice
            };

            if (!Utils.CheckContractorData(contractorData))
                return;

            Utils.UpperFirst(this.txtNameFirst);
            Utils.UpperFirst(this.txtNameLast);
            Utils.UpperFirst(this.txtPatronymic);

            this.cmd.CommandText = "AddContractorProduction";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@name_first", this.txtNameFirst.Text);
            this.cmd.Parameters.AddWithValue("@name_last", this.txtNameLast.Text);
            this.cmd.Parameters.AddWithValue("@patronymic", this.txtPatronymic.Text);
            this.cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
            this.cmd.Parameters.AddWithValue("@phone", this.txtPhone.Text);
            this.cmd.Parameters.AddWithValue("@ordid", this.cmbOrdReqs.Text.Split(' ')[0]);
            this.cmd.Parameters.AddWithValue("@price", this.txtPrice.Text);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

