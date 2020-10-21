namespace Ais
{
    partial class frmAddContractorMedia
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
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameLast = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTimestamps = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.btnAddTimestamp = new System.Windows.Forms.Button();
            this.btnRemoveTimestamp = new System.Windows.Forms.Button();
            this.cmbTimestamps = new System.Windows.Forms.ComboBox();
            this.cmbLeads = new System.Windows.Forms.ComboBox();
            this.lblLeads = new System.Windows.Forms.Label();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(354, 66);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(110, 13);
            this.lblPatronymic.TabIndex = 82;
            this.lblPatronymic.Text = "- patronymic (optional)";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(10, 63);
            this.txtPatronymic.MaxLength = 16;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(338, 20);
            this.txtPatronymic.TabIndex = 3;
            this.txtPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(354, 40);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(58, 13);
            this.lblNameLast.TabIndex = 81;
            this.lblNameLast.Text = "- last name";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(354, 14);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(58, 13);
            this.lblNameFirst.TabIndex = 80;
            this.lblNameFirst.Text = "- first name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 89);
            this.txtEmail.MaxLength = 48;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameLast
            // 
            this.txtNameLast.Location = new System.Drawing.Point(10, 37);
            this.txtNameLast.MaxLength = 16;
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(338, 20);
            this.txtNameLast.TabIndex = 2;
            this.txtNameLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(354, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 13);
            this.lblPhone.TabIndex = 77;
            this.lblPhone.Text = "- phone number (or)";
            // 
            // lblTimestamps
            // 
            this.lblTimestamps.AutoSize = true;
            this.lblTimestamps.Location = new System.Drawing.Point(354, 144);
            this.lblTimestamps.Name = "lblTimestamps";
            this.lblTimestamps.Size = new System.Drawing.Size(209, 13);
            this.lblTimestamps.TabIndex = 78;
            this.lblTimestamps.Text = "- timestamps (for round the clock channels)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "- price";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(354, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "- email (either)";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(10, 115);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(338, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(10, 168);
            this.txtPrice.MaxLength = 16;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(338, 20);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Location = new System.Drawing.Point(10, 11);
            this.txtNameFirst.MaxLength = 16;
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(338, 20);
            this.txtNameFirst.TabIndex = 1;
            this.txtNameFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTimestamp
            // 
            this.btnAddTimestamp.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTimestamp.Location = new System.Drawing.Point(298, 140);
            this.btnAddTimestamp.Name = "btnAddTimestamp";
            this.btnAddTimestamp.Size = new System.Drawing.Size(22, 22);
            this.btnAddTimestamp.TabIndex = 8;
            this.btnAddTimestamp.Text = "+";
            this.btnAddTimestamp.UseVisualStyleBackColor = true;
            this.btnAddTimestamp.Click += new System.EventHandler(this.btnAddTimestamp_Click);
            // 
            // btnRemoveTimestamp
            // 
            this.btnRemoveTimestamp.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveTimestamp.Location = new System.Drawing.Point(326, 140);
            this.btnRemoveTimestamp.Name = "btnRemoveTimestamp";
            this.btnRemoveTimestamp.Size = new System.Drawing.Size(22, 22);
            this.btnRemoveTimestamp.TabIndex = 9;
            this.btnRemoveTimestamp.Text = "-";
            this.btnRemoveTimestamp.UseVisualStyleBackColor = true;
            this.btnRemoveTimestamp.Click += new System.EventHandler(this.btnRemoveTimestamp_Click);
            // 
            // cmbTimestamps
            // 
            this.cmbTimestamps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimestamps.FormattingEnabled = true;
            this.cmbTimestamps.Location = new System.Drawing.Point(10, 141);
            this.cmbTimestamps.Name = "cmbTimestamps";
            this.cmbTimestamps.Size = new System.Drawing.Size(214, 21);
            this.cmbTimestamps.TabIndex = 6;
            // 
            // cmbLeads
            // 
            this.cmbLeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeads.FormattingEnabled = true;
            this.cmbLeads.Location = new System.Drawing.Point(10, 193);
            this.cmbLeads.Name = "cmbLeads";
            this.cmbLeads.Size = new System.Drawing.Size(338, 21);
            this.cmbLeads.TabIndex = 11;
            // 
            // lblLeads
            // 
            this.lblLeads.AutoSize = true;
            this.lblLeads.Location = new System.Drawing.Point(354, 197);
            this.lblLeads.Name = "lblLeads";
            this.lblLeads.Size = new System.Drawing.Size(44, 13);
            this.lblLeads.TabIndex = 88;
            this.lblLeads.Text = "- lead id";
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Location = new System.Drawing.Point(230, 142);
            this.txtTimestamp.MaxLength = 8;
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(62, 20);
            this.txtTimestamp.TabIndex = 7;
            this.txtTimestamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(354, 171);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "- price";
            // 
            // frmAddContractorMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 251);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTimestamp);
            this.Controls.Add(this.cmbLeads);
            this.Controls.Add(this.lblLeads);
            this.Controls.Add(this.cmbTimestamps);
            this.Controls.Add(this.btnRemoveTimestamp);
            this.Controls.Add(this.btnAddTimestamp);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTimestamps);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddContractorMedia";
            this.Text = "Add media contractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTimestamps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNameFirst;
        private System.Windows.Forms.Button btnAddTimestamp;
        private System.Windows.Forms.Button btnRemoveTimestamp;
        private System.Windows.Forms.ComboBox cmbTimestamps;
        private System.Windows.Forms.ComboBox cmbLeads;
        private System.Windows.Forms.Label lblLeads;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.Label lblPrice;
    }
}