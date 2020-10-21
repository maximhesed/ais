using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ais
{
    internal sealed class Utils
    {
        internal static string Hash(string passw) {
            byte[] hashBytes = new byte[36];
            byte[] salt = new byte[16];

            using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider()) {
                cryptoServiceProvider.GetBytes(salt);

                using (Rfc2898DeriveBytes bytesDeriver = new Rfc2898DeriveBytes(passw, salt, 40000)) {
                    byte[] hash = bytesDeriver.GetBytes(20);

                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 20);
                }
            }

            return Convert.ToBase64String(hashBytes);
        }

        internal static bool CompHash(string passw, string savedPassw) {
            byte[] hashBytes = Convert.FromBase64String(savedPassw);
            byte[] salt = new byte[16];

            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (Rfc2898DeriveBytes bytesDeriver = new Rfc2898DeriveBytes(passw, salt, 40000)) {
                byte[] hash = bytesDeriver.GetBytes(20);

                for (int i = 0; i < 20; i++) {
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                }
            }

            return true;
        }

        internal static bool CheckEmployeeData(TransportData.EmployeeData emplData) {
            if (!CheckFirstName(emplData.firstName))
                return false;

            if (!CheckLastName(emplData.lastName))
                return false;

            if (!CheckPatronymic(emplData.patronymic))
                return false;

            if (!CheckEmail(emplData.email))
                return false;

            if (!CheckPhone(emplData.phone))
                return false;

            if (!CheckPassword(emplData.passw))
                return false;

            if (emplData.passw.Text != emplData.passwRepeat.Text) {
                MessageBox.Show("Password mismatch.");

                emplData.passw.Focus();

                return false;
            }

            return true;
        }

        internal static bool CheckLeadData(TransportData.LeadData leadData) {
            if (!CheckFirstName(leadData.firstName))
                return false;

            if (!CheckLastName(leadData.lastName))
                return false;

            if (!CheckPatronymic(leadData.patronymic))
                return false;

            if (!CheckEmailOrPhone(leadData.email, leadData.phone))
                return false;

            if (string.IsNullOrEmpty(leadData.promTime.Text)) {
                MessageBox.Show("Promotional time is required.");

                leadData.promTime.Focus();

                return false;
            }

            if (!leadData.promTime.Text.All(char.IsDigit)) {
                MessageBox.Show("Promotional time is numeric value.");

                leadData.promTime.Focus();

                return false;
            }

            return true;
        }

        internal static bool CheckOrdReqData(TransportData.OrdReqData ordReqData) {
            if (string.IsNullOrWhiteSpace(ordReqData.prodName.Text)) {
                MessageBox.Show("Product name is required.");

                ordReqData.prodName.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(ordReqData.prodQuantity.Text)) {
                MessageBox.Show("Product quantity is required.");

                ordReqData.prodQuantity.Focus();

                return false;
            }

            if (!ordReqData.prodQuantity.Text.All(char.IsDigit)) {
                MessageBox.Show("Product quantity is numeric value.");

                ordReqData.prodQuantity.Focus();

                return false;
            }

            return true;
        }

        internal static bool CheckContractorData(TransportData.ContractorData contractorData) {
            if (!CheckFirstName(contractorData.firstName))
                return false;

            if (!CheckLastName(contractorData.lastName))
                return false;

            if (!CheckPatronymic(contractorData.patronymic))
                return false;

            if (!CheckEmailOrPhone(contractorData.email, contractorData.phone))
                return false;

            if (string.IsNullOrEmpty(contractorData.price.Text)) {
                MessageBox.Show("Price is required.");

                contractorData.price.Focus();

                return false;
            }

            if (!contractorData.price.Text.All(char.IsDigit)) {
                MessageBox.Show("Price is numeric value.");

                contractorData.price.Focus();

                return false;
            }

            return true;
        }

        private static bool CheckFirstName(TextBox firstName) {
            if (string.IsNullOrEmpty(firstName.Text)) {
                MessageBox.Show("First name is required.");

                firstName.Focus();

                return false;
            }
            else if (!firstName.Text.All(char.IsLetter)) {
                MessageBox.Show("First name must contain latin or russian letters only.");

                firstName.Focus();

                return false;
            }

            Utils.UpperFirst(firstName);

            return true;
        }

        private static bool CheckLastName(TextBox lastName) {
            if (string.IsNullOrEmpty(lastName.Text)) {
                MessageBox.Show("Last name is required.");

                lastName.Focus();

                return false;
            }
            else if (!lastName.Text.All(char.IsLetter)) {
                MessageBox.Show("Last name must contain latin or russian letters only.");

                lastName.Focus();

                return false;
            }

            Utils.UpperFirst(lastName);

            return true;
        }

        private static bool CheckPatronymic(TextBox patronymic) {
            if (!string.IsNullOrEmpty(patronymic.Text)) {
                if (!patronymic.Text.All(char.IsLetter)) {
                    MessageBox.Show("Patronymic must contain latin or russian letters only.");

                    patronymic.Focus();

                    return false;
                }

                UpperFirst(patronymic);
            }

            return true;
        }

        private static bool CheckEmailRegex(string email) {
            return new Regex(@"^([a-z\d]+)((\.|\-|_)([a-z\d]+))*@([a-z])([a-z\d]*)((\.(\w){2,3})+)$",
                RegexOptions.IgnoreCase).IsMatch(email);
        }

        private static bool CheckEmail(TextBox email) {
            if (string.IsNullOrEmpty(email.Text)) {
                MessageBox.Show("Email is required.");

                email.Focus();

                return false;
            }
            else if (!CheckEmailRegex(email.Text))
                return false;

            return true;
        }

        private static bool CheckPhone(TextBox phone) {
            if (!string.IsNullOrEmpty(phone.Text)) {
                if (!phone.Text.All(char.IsDigit)) {
                    MessageBox.Show("Invalid phone.");

                    phone.Focus();

                    return false;
                }

                if (phone.Text.Length < 8) {
                    MessageBox.Show("Minimum phone size is 8.");

                    phone.Focus();

                    return false;
                }
            }

            return true;
        }

        private static bool CheckPassword(TextBox passw) {
            if (string.IsNullOrEmpty(passw.Text)) {
                MessageBox.Show("Password is required.");

                passw.Focus();

                return false;
            }
            else if (passw.Text.Length < 6) {
                MessageBox.Show("Minimum password size is 6.");

                passw.Focus();

                return false;
            }

            return true;
        }

        private static bool CheckEmailOrPhone(TextBox email, TextBox phone) {
            if (!string.IsNullOrEmpty(email.Text) && !CheckEmailRegex(email.Text)) {
                MessageBox.Show("Invalid email.");

                email.Focus();

                return false;
            }
            else if (!string.IsNullOrEmpty(phone.Text) && !phone.Text.All(char.IsDigit)) {
                MessageBox.Show("Invalid phone.");

                phone.Focus();

                return false;
            }
            else if (string.IsNullOrEmpty(email.Text) && string.IsNullOrEmpty(phone.Text)) {
                MessageBox.Show("Enter email or phone.");

                email.Focus();

                return false;
            }

            return true;
        }

        internal static int GetEmployees(SqlCommand cmd, string position, ComboBox comboBox) {
            cmd.CommandText =
                "select id, name_last, name_first, patronymic, email " +
                "   from employees " +
                "       where position = '" + position + "'";

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read())
                    comboBox.Items.Add(string.Format("{0} ({1} {2})",
                        r[0],
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3] + "") ? " " + r[3] : ""),
                        r[4]));
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;

            return comboBox.Items.Count;
        }

        internal static int GetLeads(SqlCommand cmd, ComboBox comboBox) {
            cmd.CommandText =
                "select id, name_last, name_first, patronymic, email " +
                "   from leads";

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read())
                    comboBox.Items.Add(string.Format("{0} ({1} {2})",
                        r[0],
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3] + "") ? " " + r[3] : ""),
                        r[4]));
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;

            return comboBox.Items.Count;
        }

        internal static int GetOrdReqs(SqlCommand cmd, ComboBox comboBox) {
            cmd.CommandText =
                "select id, prod_name, prod_quantity, pid, lid " +
                "   from ord_reqs";

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read())
                    comboBox.Items.Add(string.Format("{0} ({1} {2} {3} {4})",
                        r[0],
                        r[1],
                        r[2],
                        r[3],
                        r[4]));
            }

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;

            return comboBox.Items.Count;
        }

        internal static string GetPersonInfo(SqlCommand cmd, string personBase, string id) {
            cmd.CommandText =
                "select id, name_last, name_first, patronymic, email" +
                "   from " + personBase +
                "       where id = " + id;

            using (SqlDataReader r = cmd.ExecuteReader()) {
                if (r.Read()) {
                    return
                        r[0] + " (" +
                        r[1] + " " + r[2] + (!string.IsNullOrEmpty(r[3] + "") ? " " + r[3] : "") + " " +
                        r[4] + ")";
                }
            }

            return "<Deleted>";
        }

        internal static string CenterString(string s, int width) {
            int pl = (width - s.Length) / 2;
            int pr = width - s.Length - pl;

            if (s.Length >= width)
                return s;

            return new string(' ', pl) + s + new string(' ', pr);
        }

        internal static void UpperFirst(TextBox txt) {
            txt.Text = char.ToUpper(txt.Text[0]) + txt.Text.ToLower().Substring(1);
        }
    }
}

