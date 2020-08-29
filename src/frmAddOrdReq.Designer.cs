namespace ais
{
    partial class frmAddOrdReq
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
            this.cmbLeads = new System.Windows.Forms.ComboBox();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLeads = new System.Windows.Forms.Label();
            this.dtpPeriod = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbLeads
            // 
            this.cmbLeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeads.FormattingEnabled = true;
            this.cmbLeads.Location = new System.Drawing.Point(12, 91);
            this.cmbLeads.Name = "cmbLeads";
            this.cmbLeads.Size = new System.Drawing.Size(334, 21);
            this.cmbLeads.TabIndex = 71;
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(352, 41);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(89, 13);
            this.lblProdQuantity.TabIndex = 69;
            this.lblProdQuantity.Text = "- product quantity";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(352, 15);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 13);
            this.lblProdName.TabIndex = 68;
            this.lblProdName.Text = "- product name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLeads
            // 
            this.lblLeads.AutoSize = true;
            this.lblLeads.Location = new System.Drawing.Point(352, 94);
            this.lblLeads.Name = "lblLeads";
            this.lblLeads.Size = new System.Drawing.Size(44, 13);
            this.lblLeads.TabIndex = 67;
            this.lblLeads.Text = "- lead id";
            // 
            // dtpPeriod
            // 
            this.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriod.Location = new System.Drawing.Point(12, 65);
            this.dtpPeriod.Name = "dtpPeriod";
            this.dtpPeriod.Size = new System.Drawing.Size(334, 20);
            this.dtpPeriod.TabIndex = 77;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(352, 67);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(66, 13);
            this.lblPeriod.TabIndex = 76;
            this.lblPeriod.Text = "- period date";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 12);
            this.txtProductName.MaxLength = 16;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(334, 20);
            this.txtProductName.TabIndex = 78;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(12, 38);
            this.txtProductQuantity.MaxLength = 10;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(334, 20);
            this.txtProductQuantity.TabIndex = 79;
            this.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddOrdReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 147);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dtpPeriod);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cmbLeads);
            this.Controls.Add(this.lblProdQuantity);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLeads);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddOrdReq";
            this.Text = "Add order request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLeads;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLeads;
        private System.Windows.Forms.DateTimePicker dtpPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductQuantity;
    }
}