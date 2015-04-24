namespace PlairesEmulator
{
    partial class PlanReqMonitoring
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plan Request Monitoring";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(19, 49);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(140, 23);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "Request Monitoring";
            this.btnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(19, 78);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(140, 23);
            this.btnMaintenance.TabIndex = 5;
            this.btnMaintenance.Text = "File Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // PlanReqMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 116);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.label1);
            this.Name = "PlanReqMonitoring";
            this.Text = "PlanReqMonitoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnMaintenance;
    }
}