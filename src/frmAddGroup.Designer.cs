namespace Ais
{
    partial class frmAddGroup
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
            this.lblGraphics = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblProducers = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCompletion = new System.Windows.Forms.Label();
            this.lblLeads = new System.Windows.Forms.Label();
            this.lblCopywriters = new System.Windows.Forms.Label();
            this.cmbProducers = new System.Windows.Forms.ComboBox();
            this.cmbArtists = new System.Windows.Forms.ComboBox();
            this.cmbGraphics = new System.Windows.Forms.ComboBox();
            this.cmbCopywriters = new System.Windows.Forms.ComboBox();
            this.cmbLeads = new System.Windows.Forms.ComboBox();
            this.dtpCompletion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblGraphics
            // 
            this.lblGraphics.AutoSize = true;
            this.lblGraphics.Location = new System.Drawing.Point(441, 67);
            this.lblGraphics.Name = "lblGraphics";
            this.lblGraphics.Size = new System.Drawing.Size(110, 13);
            this.lblGraphics.TabIndex = 61;
            this.lblGraphics.Text = "- graphics specialist id";
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(441, 41);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(89, 13);
            this.lblArtists.TabIndex = 60;
            this.lblArtists.Text = "- artist designer id";
            // 
            // lblProducers
            // 
            this.lblProducers.AutoSize = true;
            this.lblProducers.Location = new System.Drawing.Point(441, 15);
            this.lblProducers.Name = "lblProducers";
            this.lblProducers.Size = new System.Drawing.Size(66, 13);
            this.lblProducers.TabIndex = 59;
            this.lblProducers.Text = "- producer id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCompletion
            // 
            this.lblCompletion.AutoSize = true;
            this.lblCompletion.Location = new System.Drawing.Point(441, 119);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(88, 13);
            this.lblCompletion.TabIndex = 57;
            this.lblCompletion.Text = "- completion date";
            // 
            // lblLeads
            // 
            this.lblLeads.AutoSize = true;
            this.lblLeads.Location = new System.Drawing.Point(441, 145);
            this.lblLeads.Name = "lblLeads";
            this.lblLeads.Size = new System.Drawing.Size(44, 13);
            this.lblLeads.TabIndex = 58;
            this.lblLeads.Text = "- lead id";
            // 
            // lblCopywriters
            // 
            this.lblCopywriters.AutoSize = true;
            this.lblCopywriters.Location = new System.Drawing.Point(441, 93);
            this.lblCopywriters.Name = "lblCopywriters";
            this.lblCopywriters.Size = new System.Drawing.Size(72, 13);
            this.lblCopywriters.TabIndex = 56;
            this.lblCopywriters.Text = "- copywriter id";
            // 
            // cmbProducers
            // 
            this.cmbProducers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducers.FormattingEnabled = true;
            this.cmbProducers.Location = new System.Drawing.Point(12, 12);
            this.cmbProducers.Name = "cmbProducers";
            this.cmbProducers.Size = new System.Drawing.Size(423, 21);
            this.cmbProducers.TabIndex = 62;
            // 
            // cmbArtists
            // 
            this.cmbArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtists.FormattingEnabled = true;
            this.cmbArtists.Location = new System.Drawing.Point(12, 38);
            this.cmbArtists.Name = "cmbArtists";
            this.cmbArtists.Size = new System.Drawing.Size(423, 21);
            this.cmbArtists.TabIndex = 62;
            // 
            // cmbGraphics
            // 
            this.cmbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphics.FormattingEnabled = true;
            this.cmbGraphics.Location = new System.Drawing.Point(12, 64);
            this.cmbGraphics.Name = "cmbGraphics";
            this.cmbGraphics.Size = new System.Drawing.Size(423, 21);
            this.cmbGraphics.TabIndex = 62;
            // 
            // cmbCopywriters
            // 
            this.cmbCopywriters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopywriters.FormattingEnabled = true;
            this.cmbCopywriters.Location = new System.Drawing.Point(12, 90);
            this.cmbCopywriters.Name = "cmbCopywriters";
            this.cmbCopywriters.Size = new System.Drawing.Size(423, 21);
            this.cmbCopywriters.TabIndex = 62;
            // 
            // cmbLeads
            // 
            this.cmbLeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeads.FormattingEnabled = true;
            this.cmbLeads.Location = new System.Drawing.Point(12, 142);
            this.cmbLeads.Name = "cmbLeads";
            this.cmbLeads.Size = new System.Drawing.Size(423, 21);
            this.cmbLeads.TabIndex = 62;
            // 
            // dtpCompletion
            // 
            this.dtpCompletion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompletion.Location = new System.Drawing.Point(12, 117);
            this.dtpCompletion.Name = "dtpCompletion";
            this.dtpCompletion.Size = new System.Drawing.Size(423, 20);
            this.dtpCompletion.TabIndex = 63;
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 199);
            this.Controls.Add(this.dtpCompletion);
            this.Controls.Add(this.cmbLeads);
            this.Controls.Add(this.cmbCopywriters);
            this.Controls.Add(this.cmbGraphics);
            this.Controls.Add(this.cmbArtists);
            this.Controls.Add(this.cmbProducers);
            this.Controls.Add(this.lblGraphics);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblProducers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCompletion);
            this.Controls.Add(this.lblLeads);
            this.Controls.Add(this.lblCopywriters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddGroup";
            this.Text = "Add group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblProducers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCompletion;
        private System.Windows.Forms.Label lblLeads;
        private System.Windows.Forms.Label lblCopywriters;
        private System.Windows.Forms.ComboBox cmbProducers;
        private System.Windows.Forms.ComboBox cmbArtists;
        private System.Windows.Forms.ComboBox cmbGraphics;
        private System.Windows.Forms.ComboBox cmbCopywriters;
        private System.Windows.Forms.ComboBox cmbLeads;
        private System.Windows.Forms.DateTimePicker dtpCompletion;
    }
}