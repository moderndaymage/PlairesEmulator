namespace PlairesEmulator
{
    partial class PLV_EditData
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
            this.rbtOriginal = new System.Windows.Forms.RadioButton();
            this.rbtTracingCloth = new System.Windows.Forms.RadioButton();
            this.rbtWhitePrint = new System.Windows.Forms.RadioButton();
            this.rbtBluePrint = new System.Windows.Forms.RadioButton();
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
            this.lvEditData = new System.Windows.Forms.ListView();
            this.chPlanNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRollNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtOriginal
            // 
            this.rbtOriginal.AutoSize = true;
            this.rbtOriginal.Location = new System.Drawing.Point(76, 214);
            this.rbtOriginal.Name = "rbtOriginal";
            this.rbtOriginal.Size = new System.Drawing.Size(78, 21);
            this.rbtOriginal.TabIndex = 32;
            this.rbtOriginal.TabStop = true;
            this.rbtOriginal.Text = "Original";
            this.rbtOriginal.UseVisualStyleBackColor = true;
            // 
            // rbtTracingCloth
            // 
            this.rbtTracingCloth.AutoSize = true;
            this.rbtTracingCloth.Location = new System.Drawing.Point(76, 241);
            this.rbtTracingCloth.Name = "rbtTracingCloth";
            this.rbtTracingCloth.Size = new System.Drawing.Size(113, 21);
            this.rbtTracingCloth.TabIndex = 31;
            this.rbtTracingCloth.TabStop = true;
            this.rbtTracingCloth.Text = "Tracing Cloth";
            this.rbtTracingCloth.UseVisualStyleBackColor = true;
            // 
            // rbtWhitePrint
            // 
            this.rbtWhitePrint.AutoSize = true;
            this.rbtWhitePrint.Location = new System.Drawing.Point(76, 295);
            this.rbtWhitePrint.Name = "rbtWhitePrint";
            this.rbtWhitePrint.Size = new System.Drawing.Size(98, 21);
            this.rbtWhitePrint.TabIndex = 30;
            this.rbtWhitePrint.TabStop = true;
            this.rbtWhitePrint.Text = "White Print";
            this.rbtWhitePrint.UseVisualStyleBackColor = true;
            // 
            // rbtBluePrint
            // 
            this.rbtBluePrint.AutoSize = true;
            this.rbtBluePrint.Location = new System.Drawing.Point(76, 268);
            this.rbtBluePrint.Name = "rbtBluePrint";
            this.rbtBluePrint.Size = new System.Drawing.Size(90, 21);
            this.rbtBluePrint.TabIndex = 29;
            this.rbtBluePrint.TabStop = true;
            this.rbtBluePrint.Text = "Blue Print";
            this.rbtBluePrint.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(76, 322);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Type:*";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(76, 178);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(160, 22);
            this.txtRemarks.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Remarks:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(76, 147);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(160, 22);
            this.txtLocation.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Location:*";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(76, 118);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtRollNo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Roll No:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plan No:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Modify Plan Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "*-Required Fields";
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
            this.lvEditData.Location = new System.Drawing.Point(242, 50);
            this.lvEditData.Name = "lvEditData";
            this.lvEditData.Size = new System.Drawing.Size(551, 306);
            this.lvEditData.TabIndex = 35;
            this.lvEditData.UseCompatibleStateImageBehavior = false;
            this.lvEditData.View = System.Windows.Forms.View.Details;
            this.lvEditData.SelectedIndexChanged += new System.EventHandler(this.lvInquiry_SelectedIndexChanged);
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
            this.chRemarks.Width = 151;
            // 
            // chRollNo
            // 
            this.chRollNo.Text = "Roll No";
            this.chRollNo.Width = 67;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 86;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(76, 86);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.ReadOnly = true;
            this.txtPlanNo.Size = new System.Drawing.Size(160, 22);
            this.txtPlanNo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Available Plans:";
            // 
            // PLV_EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 360);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlanNo);
            this.Controls.Add(this.lvEditData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtOriginal);
            this.Controls.Add(this.rbtTracingCloth);
            this.Controls.Add(this.rbtWhitePrint);
            this.Controls.Add(this.rbtBluePrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PLV_EditData";
            this.Text = "pLaiRes Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLV_EditData_FormClosing);
            this.Load += new System.EventHandler(this.PLV_EditData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtOriginal;
        private System.Windows.Forms.RadioButton rbtTracingCloth;
        private System.Windows.Forms.RadioButton rbtWhitePrint;
        private System.Windows.Forms.RadioButton rbtBluePrint;
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
        private System.Windows.Forms.ListView lvEditData;
        private System.Windows.Forms.ColumnHeader chPlanNo;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.ColumnHeader chRemarks;
        private System.Windows.Forms.ColumnHeader chRollNo;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.Label label8;
    }
}