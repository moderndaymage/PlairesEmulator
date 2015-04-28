namespace PlairesEmulator
{
    partial class PLV_AddData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbtBluePrint = new System.Windows.Forms.RadioButton();
            this.rbtWhitePrint = new System.Windows.Forms.RadioButton();
            this.rbtTracingCloth = new System.Windows.Forms.RadioButton();
            this.rbtOriginal = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
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
            this.cbxPlanType.Location = new System.Drawing.Point(99, 89);
            this.cbxPlanType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPlanType.Name = "cbxPlanType";
            this.cbxPlanType.Size = new System.Drawing.Size(160, 24);
            this.cbxPlanType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plan Type:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plan No:*";
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(99, 125);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(100, 22);
            this.txtPlanNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Roll No:*";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(99, 155);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtRollNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location:*";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(99, 189);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(160, 22);
            this.txtLocation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(99, 220);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(160, 22);
            this.txtRemarks.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type:*";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(19, 364);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 53);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert to Database";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rbtBluePrint
            // 
            this.rbtBluePrint.AutoSize = true;
            this.rbtBluePrint.Location = new System.Drawing.Point(99, 310);
            this.rbtBluePrint.Name = "rbtBluePrint";
            this.rbtBluePrint.Size = new System.Drawing.Size(90, 21);
            this.rbtBluePrint.TabIndex = 13;
            this.rbtBluePrint.TabStop = true;
            this.rbtBluePrint.Text = "Blue Print";
            this.rbtBluePrint.UseVisualStyleBackColor = true;
            // 
            // rbtWhitePrint
            // 
            this.rbtWhitePrint.AutoSize = true;
            this.rbtWhitePrint.Location = new System.Drawing.Point(99, 337);
            this.rbtWhitePrint.Name = "rbtWhitePrint";
            this.rbtWhitePrint.Size = new System.Drawing.Size(98, 21);
            this.rbtWhitePrint.TabIndex = 14;
            this.rbtWhitePrint.TabStop = true;
            this.rbtWhitePrint.Text = "White Print";
            this.rbtWhitePrint.UseVisualStyleBackColor = true;
            // 
            // rbtTracingCloth
            // 
            this.rbtTracingCloth.AutoSize = true;
            this.rbtTracingCloth.Location = new System.Drawing.Point(99, 283);
            this.rbtTracingCloth.Name = "rbtTracingCloth";
            this.rbtTracingCloth.Size = new System.Drawing.Size(113, 21);
            this.rbtTracingCloth.TabIndex = 15;
            this.rbtTracingCloth.TabStop = true;
            this.rbtTracingCloth.Text = "Tracing Cloth";
            this.rbtTracingCloth.UseVisualStyleBackColor = true;
            // 
            // rbtOriginal
            // 
            this.rbtOriginal.AutoSize = true;
            this.rbtOriginal.Location = new System.Drawing.Point(99, 256);
            this.rbtOriginal.Name = "rbtOriginal";
            this.rbtOriginal.Size = new System.Drawing.Size(78, 21);
            this.rbtOriginal.TabIndex = 16;
            this.rbtOriginal.TabStop = true;
            this.rbtOriginal.Text = "Original";
            this.rbtOriginal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "*-Required Fields";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 36);
            this.label8.TabIndex = 18;
            this.label8.Text = "Add new Plan";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(123, 364);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 53);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "Import From Excel(Beta)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // PLV_AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 427);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbtOriginal);
            this.Controls.Add(this.rbtTracingCloth);
            this.Controls.Add(this.rbtWhitePrint);
            this.Controls.Add(this.rbtBluePrint);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlanNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPlanType);
            this.Name = "PLV_AddData";
            this.Text = "pLaiRes Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLV_AddData_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlanType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbtBluePrint;
        private System.Windows.Forms.RadioButton rbtWhitePrint;
        private System.Windows.Forms.RadioButton rbtTracingCloth;
        private System.Windows.Forms.RadioButton rbtOriginal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnImport;
    }
}