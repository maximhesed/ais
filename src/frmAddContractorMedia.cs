using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAddContractorMedia : Form
    {
        private readonly SqlCommand cmd;

        public frmAddContractorMedia(SqlCommand cmd) {
            InitializeComponent();

            this.cmd = cmd;

            if (Utils.GetLeads(cmd, this.cmbLeads) == 0) {
                MessageBox.Show("No leads available.");

                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string timestamps = "";

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

            if (this.cmbTimestamps.Items.Count > 0) {
                foreach (object t in this.cmbTimestamps.Items)
                    timestamps += t + ", ";

                timestamps = timestamps.Remove(timestamps.Length - 2, 2);
            }

            this.cmd.CommandText = "AddContractorMedia";
            this.cmd.CommandType = CommandType.StoredProcedure;

            this.cmd.Parameters.Clear();
            this.cmd.Parameters.AddWithValue("@name_first", this.txtNameFirst.Text);
            this.cmd.Parameters.AddWithValue("@name_last", this.txtNameLast.Text);
            this.cmd.Parameters.AddWithValue("@patronymic", this.txtPatronymic.Text);
            this.cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
            this.cmd.Parameters.AddWithValue("@phone", this.txtPhone.Text);
            this.cmd.Parameters.AddWithValue("@price", this.txtPrice.Text);
            this.cmd.Parameters.AddWithValue("@timestamps", timestamps);
            this.cmd.Parameters.AddWithValue("@lid", this.cmbLeads.Text.Split(' ')[0]);

            if (this.cmd.ExecuteNonQuery() == 0)
                MessageBox.Show("No rows have been inserted.");

            Close();
        }

        private void btnAddTimestamp_Click(object sender, EventArgs e) {
            if (!new Regex(@"^(\d){2}:(\d){2}:(\d){2}$").IsMatch(this.txtTimestamp.Text)
                    || Convert.ToInt32(this.txtTimestamp.Text.Split(':')[0]) > 23
                    || Convert.ToInt32(this.txtTimestamp.Text.Split(':')[1]) > 59
                    || Convert.ToInt32(this.txtTimestamp.Text.Split(':')[2]) > 59) {
                MessageBox.Show("Time format: \"hh:mm:ss\".");

                this.txtTimestamp.Focus();

                return;
            }

            if (this.cmbTimestamps.Items.Count > 0) {
                foreach (object t in this.cmbTimestamps.Items) {
                    if (this.txtTimestamp == t) {
                        MessageBox.Show("This timestamp is already on the list.");

                        this.txtTimestamp.Focus();

                        return;
                    }
                }
            }

            if (this.cmbTimestamps.Items.Count == 24) {
                MessageBox.Show("Max timestamps count is 24.");

                return;
            }

            this.cmbTimestamps.Items.Add(this.txtTimestamp.Text);
            this.cmbTimestamps.SelectedItem = this.txtTimestamp.Text;
        }

        private void btnRemoveTimestamp_Click(object sender, EventArgs e) {
            if (this.cmbTimestamps.SelectedIndex != -1)
                this.cmbTimestamps.Items.RemoveAt(this.cmbTimestamps.SelectedIndex);
        }
    }
}

