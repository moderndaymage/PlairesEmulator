namespace PlairesEmulator
{
    partial class PLV_Reindex
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.cbxPlanType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtOldPlanNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSearchByPlanType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lvEditData = new System.Windows.Forms.ListView();
            this.chPlanNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRollNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Type:*";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Location = new System.Drawing.Point(124, 225);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(160, 22);
            this.txtRemarks.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Remarks:";
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(124, 194);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(160, 22);
            this.txtLocation.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Location:*";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Enabled = false;
            this.txtRollNo.Location = new System.Drawing.Point(124, 165);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtRollNo.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Roll No:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Old Plan No:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "New Plan No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "New Plan Type:";
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(124, 126);
            this.txtPlanNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(136, 22);
            this.txtPlanNo.TabIndex = 48;
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
            this.cbxPlanType.Location = new System.Drawing.Point(124, 87);
            this.cbxPlanType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPlanType.Name = "cbxPlanType";
            this.cbxPlanType.Size = new System.Drawing.Size(164, 24);
            this.cbxPlanType.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 32);
            this.label8.TabIndex = 51;
            this.label8.Text = "Reindex Plan";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(122, 258);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(162, 22);
            this.txtType.TabIndex = 52;
            // 
            // txtOldPlanNo
            // 
            this.txtOldPlanNo.Location = new System.Drawing.Point(124, 55);
            this.txtOldPlanNo.Name = "txtOldPlanNo";
            this.txtOldPlanNo.ReadOnly = true;
            this.txtOldPlanNo.Size = new System.Drawing.Size(164, 22);
            this.txtOldPlanNo.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Search by Plan Type:";
            // 
            // cbxSearchByPlanType
            // 
            this.cbxSearchByPlanType.FormattingEnabled = true;
            this.cbxSearchByPlanType.Items.AddRange(new object[] {
            "(LRC)PSD",
            "(LRC)PCS",
            "(LRC)PCN",
            "(LRC)RL",
            "(LRC)RS"});
            this.cbxSearchByPlanType.Location = new System.Drawing.Point(740, 23);
            this.cbxSearchByPlanType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchByPlanType.Name = "cbxSearchByPlanType";
            this.cbxSearchByPlanType.Size = new System.Drawing.Size(164, 24);
            this.cbxSearchByPlanType.TabIndex = 56;
            this.cbxSearchByPlanType.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByPlanType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Available Plans:";
            // 
            // lvEditData
            // 
            this.lvEditData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlanNo,
            this.chLocation,
            this.chRemarks,
            this.chType,
            this.chRollNo});
            this.lvEditData.FullRowSelect = true;
            this.lvEditData.Location = new System.Drawing.Point(295, 54);
            this.lvEditData.Name = "lvEditData";
            this.lvEditData.Size = new System.Drawing.Size(614, 280);
            this.lvEditData.TabIndex = 54;
            this.lvEditData.UseCompatibleStateImageBehavior = false;
            this.lvEditData.View = System.Windows.Forms.View.Details;
            this.lvEditData.SelectedIndexChanged += new System.EventHandler(this.lvEditData_SelectedIndexChanged);
            // 
            // chPlanNo
            // 
            this.chPlanNo.Text = "Plan No";
            this.chPlanNo.Width = 103;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 136;
            // 
            // chRemarks
            // 
            this.chRemarks.Text = "Remarks";
            this.chRemarks.Width = 176;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 106;
            // 
            // chRollNo
            // 
            this.chRollNo.Text = "Roll No";
            this.chRollNo.Width = 87;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(209, 300);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 34);
            this.btnViewAll.TabIndex = 58;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Action:";
            // 
            // PLV_Reindex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 338);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxSearchByPlanType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvEditData);
            this.Controls.Add(this.txtOldPlanNo);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlanNo);
            this.Controls.Add(this.cbxPlanType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PLV_Reindex";
            this.Text = "pLaiRes Emulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PLV_Reindex_FormClosed);
            this.Load += new System.EventHandler(this.PLV_Reindex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.ComboBox cbxPlanType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtOldPlanNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxSearchByPlanType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvEditData;
        private System.Windows.Forms.ColumnHeader chPlanNo;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.ColumnHeader chRemarks;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chRollNo;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label label11;
    }
}