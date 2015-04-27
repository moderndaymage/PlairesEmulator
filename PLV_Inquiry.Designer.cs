namespace PlairesEmulator
{
    partial class PLV_Inquiry
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
            this.cbxPlanType = new System.Windows.Forms.ComboBox();
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lvInquiry = new System.Windows.Forms.ListView();
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRollNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbxPlanType
            // 
            this.cbxPlanType.FormattingEnabled = true;
            this.cbxPlanType.Items.AddRange(new object[] {
            "(LRC)PSD",
            "(LRC)PCS",
            "(LRC)PCN",
            "(LRC)RL",
            "(LRC)RS"});
            this.cbxPlanType.Location = new System.Drawing.Point(101, 43);
            this.cbxPlanType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPlanType.Name = "cbxPlanType";
            this.cbxPlanType.Size = new System.Drawing.Size(160, 24);
            this.cbxPlanType.TabIndex = 0;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(101, 76);
            this.txtPlanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(132, 22);
            this.txtPlanNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plan Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plan No:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(263, 74);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvInquiry
            // 
            this.lvInquiry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLocation,
            this.chRollNo,
            this.chRemarks,
            this.chType});
            this.lvInquiry.Location = new System.Drawing.Point(19, 109);
            this.lvInquiry.Name = "lvInquiry";
            this.lvInquiry.Size = new System.Drawing.Size(463, 150);
            this.lvInquiry.TabIndex = 6;
            this.lvInquiry.UseCompatibleStateImageBehavior = false;
            this.lvInquiry.View = System.Windows.Forms.View.Details;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 139;
            // 
            // chRollNo
            // 
            this.chRollNo.Text = "Roll No";
            // 
            // chRemarks
            // 
            this.chRemarks.Text = "Remarks";
            this.chRemarks.Width = 116;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 144;
            // 
            // PLV_Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 384);
            this.Controls.Add(this.lvInquiry);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlanNo);
            this.Controls.Add(this.cbxPlanType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PLV_Inquiry";
            this.Text = "PLV_Inquiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLV_Inquiry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlanType;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lvInquiry;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.ColumnHeader chRollNo;
        private System.Windows.Forms.ColumnHeader chRemarks;
        private System.Windows.Forms.ColumnHeader chType;
    }
}