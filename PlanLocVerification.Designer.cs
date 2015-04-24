namespace PlairesEmulator
{
    partial class PlanLocVerification
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
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(12, 49);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(140, 23);
            this.btnMaintenance.TabIndex = 0;
            this.btnMaintenance.Text = "File Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plan Location Verification";
            // 
            // btnInquiry
            // 
            this.btnInquiry.Location = new System.Drawing.Point(12, 78);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(140, 23);
            this.btnInquiry.TabIndex = 3;
            this.btnInquiry.Text = "Location Inquiry";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // PlanLocVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 119);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMaintenance);
            this.Name = "PlanLocVerification";
            this.Text = "PlanLocVerification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlanLocVerification_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInquiry;
    }
}