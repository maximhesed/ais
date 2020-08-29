using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ais
{
    public partial class frmAddEmployee : Form
    {
        private readonly SqlCommand cmd;

        public frmAddEmployee(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;
            this.cmbDepartment.Items.Add("Lead service");
            this.cmbDepartment.Items.Add("Creative");
            this.cmbDepartment.Items.Add("Media");
            this.cmbDepartment.Items.Add("Production");
            this.cmbDepartment.Items.Add("Courier");
            this.cmbDepartment.SelectedIndex = 0;

            UpdateDepartmentsList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
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

            this.cmd.CommandText =
                "select id" +
                "   from employees" +
                "       where email = '" + this.txtEmail.Text + "'";

            using (SqlDataReader r = this.cmd.ExecuteReader()) {
                if (r.Read()) {
                    MessageBox.Show("This email is already registered in AIS.");

                    return;
                }
            }

            hash = Utils.Hash(this.txtPassw.Text);

            this.cmd.CommandText = "AddEmployee";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@name_first", this.txtNameFirst.Text);
            this.cmd.Parameters.AddWithValue("@name_last", this.txtNameLast.Text);
            this.cmd.Parameters.AddWithValue("@patronymic", this.txtPatronymic.Text);
            this.cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
            this.cmd.Parameters.AddWithValue("@password_hash", hash);
            this.cmd.Parameters.AddWithValue("@phone", this.txtPhone.Text);
            this.cmd.Parameters.AddWithValue("@department", this.cmbDepartment.Text);
            this.cmd.Parameters.AddWithValue("@position", this.cmbPosition.Text);
            this.cmd.Parameters.AddWithValue("@reg_date", DateTime.Now.Date);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateDepartmentsList();
        }

        private void UpdateDepartmentsList() {
            this.cmbPosition.Items.Clear();

            switch (this.cmbDepartment.Text) {
                case "Lead service":
                    this.cmbPosition.Items.Add("Director");
                    this.cmbPosition.Items.Add("Seniour manager");
                    this.cmbPosition.Items.Add("Manager");

                    break;

                case "Creative":
                    this.cmbPosition.Items.Add("Director");
                    this.cmbPosition.Items.Add("General producer");
                    this.cmbPosition.Items.Add("Producer");
                    this.cmbPosition.Items.Add("Artist designer");
                    this.cmbPosition.Items.Add("Graphics specialist");
                    this.cmbPosition.Items.Add("Copywriter");

                    break;

                case "Media":
                    this.cmbPosition.Items.Add("Director");
                    this.cmbPosition.Items.Add("Media planner specialist");
                    this.cmbPosition.Items.Add("Media buyer specialist");
                    this.cmbPosition.Items.Add("Monitoring specialist");

                    break;

                case "Production":
                    this.cmbPosition.Items.Add("Director");
                    this.cmbPosition.Items.Add("Seniour manager");
                    this.cmbPosition.Items.Add("Manager");

                    break;

                case "Courier":
                    this.cmbPosition.Items.Add("Director");
                    this.cmbPosition.Items.Add("Seniour manager");
                    this.cmbPosition.Items.Add("Manager");
                    this.cmbPosition.Items.Add("Courier");

                    break;
            }

            this.cmbPosition.SelectedIndex = 0;
        }
    }
}

