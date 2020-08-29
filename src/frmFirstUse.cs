using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ais
{
    public partial class frmFirstUse : Form
    {
        private readonly SqlCommand cmd;

        public frmFirstUse(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            string hash;

            TransportData.EmployeeData emplData = new TransportData.EmployeeData {
                firstName = this.txtNameFirst,
                lastName = this.txtNameLast,
                patronymic = this.txtPatronymic,
                email = this.txtEmail,
                passw = this.txtPassw,
                passwRepeat = this.txtPasswRepeat,
                phone = this.txtPhone
            };

            if (!Utils.CheckEmployeeData(emplData))
                return;

            hash = Utils.Hash(this.txtPassw.Text);

            this.cmd.CommandText = "AddEmployee";
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@name_first", this.txtNameFirst.Text);
            this.cmd.Parameters.AddWithValue("@name_last", this.txtNameLast.Text);
            this.cmd.Parameters.AddWithValue("@patronymic", this.txtPatronymic.Text);
            this.cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
            this.cmd.Parameters.AddWithValue("@password_hash", hash);
            this.cmd.Parameters.AddWithValue("@phone", this.txtPhone.Text);
            this.cmd.Parameters.AddWithValue("@department", "Administrative");
            this.cmd.Parameters.AddWithValue("@position", "Director");
            this.cmd.Parameters.AddWithValue("@reg_date", DateTime.Now.Date);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }
    }
}

