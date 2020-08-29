namespace ais
{
    partial class frmAddLead
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
            this.lblPromTime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPromTime = new System.Windows.Forms.TextBox();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtpAppeal = new System.Windows.Forms.DateTimePicker();
            this.lblAppeal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(163, 67);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(110, 13);
            this.lblPatronymic.TabIndex = 48;
            this.lblPatronymic.Text = "- patronymic (optional)";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(12, 64);
            this.txtPatronymic.MaxLength = 16;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(145, 20);
            this.txtPatronymic.TabIndex = 37;
            this.txtPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(163, 41);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(58, 13);
            this.lblNameLast.TabIndex = 47;
            this.lblNameLast.Text = "- last name";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(163, 15);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(58, 13);
            this.lblNameFirst.TabIndex = 46;
            this.lblNameFirst.Text = "- first name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 90);
            this.txtEmail.MaxLength = 48;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameLast
            // 
            this.txtNameLast.Location = new System.Drawing.Point(12, 38);
            this.txtNameLast.MaxLength = 16;
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(145, 20);
            this.txtNameLast.TabIndex = 36;
            this.txtNameLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPromTime
            // 
            this.lblPromTime.AutoSize = true;
            this.lblPromTime.Location = new System.Drawing.Point(163, 145);
            this.lblPromTime.Name = "lblPromTime";
            this.lblPromTime.Size = new System.Drawing.Size(129, 13);
            this.lblPromTime.TabIndex = 45;
            this.lblPromTime.Text = "- promotional time (in sec.)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(163, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "- email (either)";
            // 
            // txtPromTime
            // 
            this.txtPromTime.Location = new System.Drawing.Point(12, 142);
            this.txtPromTime.MaxLength = 16;
            this.txtPromTime.Name = "txtPromTime";
            this.txtPromTime.Size = new System.Drawing.Size(145, 20);
            this.txtPromTime.TabIndex = 41;
            this.txtPromTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Location = new System.Drawing.Point(12, 12);
            this.txtNameFirst.MaxLength = 16;
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(145, 20);
            this.txtNameFirst.TabIndex = 35;
            this.txtNameFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 116);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 41;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(163, 119);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 13);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.Text = "- phone number (or)";
            // 
            // dtpAppeal
            // 
            this.dtpAppeal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppeal.Location = new System.Drawing.Point(12, 168);
            this.dtpAppeal.Name = "dtpAppeal";
            this.dtpAppeal.Size = new System.Drawing.Size(145, 20);
            this.dtpAppeal.TabIndex = 79;
            // 
            // lblAppeal
            // 
            this.lblAppeal.AutoSize = true;
            this.lblAppeal.Location = new System.Drawing.Point(163, 171);
            this.lblAppeal.Name = "lblAppeal";
            this.lblAppeal.Size = new System.Drawing.Size(69, 13);
            this.lblAppeal.TabIndex = 78;
            this.lblAppeal.Text = "- appeal date";
            // 
            // frmAddLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 226);
            this.Controls.Add(this.dtpAppeal);
            this.Controls.Add(this.lblAppeal);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPromTime);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPromTime);
            this.Controls.Add(this.txtNameFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddLead";
            this.Text = "Add lead";
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
        private System.Windows.Forms.Label lblPromTime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPromTime;
        private System.Windows.Forms.TextBox txtNameFirst;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpAppeal;
        private System.Windows.Forms.Label lblAppeal;
    }
}