using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmAdm : Form
    {
        private readonly FormAdmConstructor constructor;
        private readonly List<int> searchResultsIndices = new List<int>();
        private ListBox lstSel = null; // pointer to list (no need to dispose)
        private int offset = 0;

        public frmAdm(FormAdmConstructor constructor) {
            InitializeComponent();

            SuspendLayout();

            this.Controls.Add(constructor.mns);
            this.Controls.Add(constructor.searchBox);
            this.Controls.Add(constructor.tbc);

            /* Contols in-form events setup. */
            constructor.searchBox.TextChanged += new EventHandler(searchBox_TextChanged);
            constructor.searchBox.KeyDown += new KeyEventHandler(searchBox_SwitchResult);
            constructor.tbc.SelectedIndexChanged += new EventHandler(tbc_SelectedIndexChanged);

            constructor.searchBox.BringToFront();

            ResumeLayout(false);
            PerformLayout();

            this.constructor = constructor;
        }

        private void frmAdm_Load(object sender, EventArgs e) {
            tbc_SelectedIndexChanged(this.constructor.tbc, null);

            CenterToScreen();
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            string text = ((TextBox) sender).Text;

            this.lstSel = this.constructor.GetCurrList();

            if (string.IsNullOrEmpty(text)) {
                this.lstSel = null;

                return;
            }

            this.offset = 0;
            this.searchResultsIndices.Clear();
            this.lstSel.ClearSelected();

            foreach (int index in SearchInList(text.ToLower(), this.lstSel))
                this.searchResultsIndices.Add(index);

            if (this.searchResultsIndices.Count > 0)
                this.lstSel.SelectedIndex = this.searchResultsIndices[0];
        }

        private void searchBox_SwitchResult(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (this.lstSel != null) {
                    if ((ModifierKeys & Keys.Shift) == Keys.Shift) {
                        if (this.offset > 0) {
                            this.lstSel.ClearSelected();
                            this.lstSel.SelectedIndex = this.searchResultsIndices[this.offset -= 1];
                        }
                    }
                    else {
                        if (this.offset < this.searchResultsIndices.Count - 1) {
                            this.lstSel.ClearSelected();
                            this.lstSel.SelectedIndex = this.searchResultsIndices[this.offset += 1];
                        }
                    }
                }

                /* Suppress sound. */
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbc_SelectedIndexChanged(object sender, EventArgs e) {
            switch (((TabControl) sender).SelectedTab.Text) {
                case "Employees":
                    this.constructor.UpdateTabEmployees();

                    break;

                case "Leads":
                    this.constructor.UpdateTabLeads();

                    break;

                case "Groups":
                    this.constructor.UpdateTabGroups();

                    break;

                case "Order requests":
                    this.constructor.UpdateTabOrdReqs();

                    break;

                case "Contractors":
                    this.constructor.UpdateTabContractors();

                    break;

                case "Stock":
                    this.constructor.UpdateTabStock();

                    break;
            }

            this.constructor.searchBox.Location = new Point(this.constructor.tbc.Width - 102, 2);
            this.Size = new Size(this.constructor.tbc.Width + 16, this.constructor.tbc.Height + 62);
        }

        private IEnumerable<int> SearchInList(string text, ListBox lst) {
            for (int i = 0; i < lst.Items.Count; i++) {
                if ((lst.Items[i] + "").ToLower().Contains(text))
                    yield return i;
            }
        }
    }
}