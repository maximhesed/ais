namespace Ais
{
    partial class frmAddContractorProduction
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
            this.cmbOrdReqs = new System.Windows.Forms.ComboBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameLast = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOrdReqs = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOrdReqs
            // 
            this.cmbOrdReqs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdReqs.FormattingEnabled = true;
            this.cmbOrdReqs.Location = new System.Drawing.Point(12, 142);
            this.cmbOrdReqs.Name = "cmbOrdReqs";
            this.cmbOrdReqs.Size = new System.Drawing.Size(419, 21);
            this.cmbOrdReqs.TabIndex = 6;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(437, 67);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(110, 13);
            this.lblPatronymic.TabIndex = 65;
            this.lblPatronymic.Text = "- patronymic (optional)";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(12, 64);
            this.txtPatronymic.MaxLength = 16;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(419, 20);
            this.txtPatronymic.TabIndex = 3;
            this.txtPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(437, 41);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(58, 13);
            this.lblNameLast.TabIndex = 64;
            this.lblNameLast.Text = "- last name";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(437, 15);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(58, 13);
            this.lblNameFirst.TabIndex = 63;
            this.lblNameFirst.Text = "- first name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 90);
            this.txtEmail.MaxLength = 48;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(419, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameLast
            // 
            this.txtNameLast.Location = new System.Drawing.Point(12, 38);
            this.txtNameLast.MaxLength = 16;
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(419, 20);
            this.txtNameLast.TabIndex = 2;
            this.txtNameLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(437, 119);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 13);
            this.lblPhone.TabIndex = 60;
            this.lblPhone.Text = "- phone number (or)";
            // 
            // lblOrdReqs
            // 
            this.lblOrdReqs.AutoSize = true;
            this.lblOrdReqs.Location = new System.Drawing.Point(437, 145);
            this.lblOrdReqs.Name = "lblOrdReqs";
            this.lblOrdReqs.Size = new System.Drawing.Size(86, 13);
            this.lblOrdReqs.TabIndex = 61;
            this.lblOrdReqs.Text = "- order request id";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(437, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 59;
            this.lblPrice.Text = "- price";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(437, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "- email (either)";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 116);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(419, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 169);
            this.txtPrice.MaxLength = 16;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(419, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Location = new System.Drawing.Point(12, 12);
            this.txtNameFirst.MaxLength = 16;
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(419, 20);
            this.txtNameFirst.TabIndex = 1;
            this.txtNameFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddContractorProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 226);
            this.Controls.Add(this.cmbOrdReqs);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblOrdReqs);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddContractorProduction";
            this.Text = "Add production contractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrdReqs;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOrdReqs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNameFirst;
    }
}