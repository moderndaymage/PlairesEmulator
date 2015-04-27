namespace PlairesEmulator
{
    partial class PLV_Maintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReindex = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.mtxPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Addition Records";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 86);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Record Editing";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReindex
            // 
            this.btnReindex.Location = new System.Drawing.Point(17, 140);
            this.btnReindex.Margin = new System.Windows.Forms.Padding(4);
            this.btnReindex.Name = "btnReindex";
            this.btnReindex.Size = new System.Drawing.Size(160, 33);
            this.btnReindex.TabIndex = 2;
            this.btnReindex.Text = "File Reindexing";
            this.btnReindex.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(16, 194);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(160, 33);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // mtxPassword
            // 
            this.mtxPassword.Location = new System.Drawing.Point(210, 46);
            this.mtxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mtxPassword.Mask = "*";
            this.mtxPassword.Name = "mtxPassword";
            this.mtxPassword.Size = new System.Drawing.Size(132, 22);
            this.mtxPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // PLV_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxPassword);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnReindex);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PLV_Maintenance";
            this.Text = "pLaiRes Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLV_Maintenance_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReindex;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.MaskedTextBox mtxPassword;
        private System.Windows.Forms.Label label1;
    }
}