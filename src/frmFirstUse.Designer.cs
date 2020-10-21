namespace Ais
{
    partial class frmFirstUse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.txtPasswRepeat = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassw = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNameLast = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "In the employees table no one lines. Probably, you use AIS at first time.\r\nIf not" +
    ", please contact AIS support. Otherwise, follow further instructions in\r\nthis wi" +
    "ndow to configure AIS before first use.";
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Location = new System.Drawing.Point(15, 62);
            this.txtNameFirst.MaxLength = 16;
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(145, 20);
            this.txtNameFirst.TabIndex = 1;
            this.txtNameFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(15, 166);
            this.txtPassw.MaxLength = 32;
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(145, 20);
            this.txtPassw.TabIndex = 5;
            this.txtPassw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassw.UseSystemPasswordChar = true;
            // 
            // txtPasswRepeat
            // 
            this.txtPasswRepeat.Location = new System.Drawing.Point(15, 192);
            this.txtPasswRepeat.MaxLength = 32;
            this.txtPasswRepeat.Name = "txtPasswRepeat";
            this.txtPasswRepeat.Size = new System.Drawing.Size(145, 20);
            this.txtPasswRepeat.TabIndex = 6;
            this.txtPasswRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswRepeat.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 218);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(166, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "- your email;";
            // 
            // lblPassw
            // 
            this.lblPassw.AutoSize = true;
            this.lblPassw.Location = new System.Drawing.Point(166, 169);
            this.lblPassw.Name = "lblPassw";
            this.lblPassw.Size = new System.Drawing.Size(205, 13);
            this.lblPassw.TabIndex = 6;
            this.lblPassw.Text = "- your password (repeat it in the next field);";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(166, 221);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(153, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "- your phone number (optional).";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(50, 246);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNameLast
            // 
            this.txtNameLast.Location = new System.Drawing.Point(15, 88);
            this.txtNameLast.MaxLength = 16;
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(145, 20);
            this.txtNameLast.TabIndex = 2;
            this.txtNameLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 140);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(166, 65);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(84, 13);
            this.lblNameFirst.TabIndex = 11;
            this.lblNameFirst.Text = "- your first name;";
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(166, 91);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(84, 13);
            this.lblNameLast.TabIndex = 12;
            this.lblNameLast.Text = "- your last name;";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(15, 114);
            this.txtPatronymic.MaxLength = 16;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(145, 20);
            this.txtPatronymic.TabIndex = 3;
            this.txtPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(166, 117);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(136, 13);
            this.lblPatronymic.TabIndex = 14;
            this.lblPatronymic.Text = "- your patronymic (optional);";
            // 
            // frmFirstUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 278);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPassw);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPasswRepeat);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFirstUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameFirst;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.TextBox txtPasswRepeat;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassw;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtNameLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblPatronymic;
    }
}