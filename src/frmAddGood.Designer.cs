namespace Ais
{
    partial class frmAddGood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.lblReceive = new System.Windows.Forms.Label();
            this.cmbOrdReqs = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrdReqs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpReceive
            // 
            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceive.Location = new System.Drawing.Point(12, 38);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(445, 20);
            this.dtpReceive.TabIndex = 86;
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Location = new System.Drawing.Point(463, 40);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(72, 13);
            this.lblReceive.TabIndex = 85;
            this.lblReceive.Text = "- receive date";
            // 
            // cmbOrdReqs
            // 
            this.cmbOrdReqs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdReqs.FormattingEnabled = true;
            this.cmbOrdReqs.Location = new System.Drawing.Point(12, 11);
            this.cmbOrdReqs.Name = "cmbOrdReqs";
            this.cmbOrdReqs.Size = new System.Drawing.Size(445, 21);
            this.cmbOrdReqs.TabIndex = 84;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrdReqs
            // 
            this.lblOrdReqs.AutoSize = true;
            this.lblOrdReqs.Location = new System.Drawing.Point(463, 14);
            this.lblOrdReqs.Name = "lblOrdReqs";
            this.lblOrdReqs.Size = new System.Drawing.Size(86, 13);
            this.lblOrdReqs.TabIndex = 81;
            this.lblOrdReqs.Text = "- order request id";
            // 
            // frmAddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 94);
            this.Controls.Add(this.dtpReceive);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.cmbOrdReqs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOrdReqs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddGood";
            this.Text = "Add good";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.ComboBox cmbOrdReqs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOrdReqs;
    }
}