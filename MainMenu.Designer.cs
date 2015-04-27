namespace PlairesEmulator
{
    partial class MainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnPRM = new System.Windows.Forms.Button();
            this.btnPLV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plan Inquiry and Retrieval System";
            // 
            // btnPRM
            // 
            this.btnPRM.Location = new System.Drawing.Point(213, 107);
            this.btnPRM.Margin = new System.Windows.Forms.Padding(4);
            this.btnPRM.Name = "btnPRM";
            this.btnPRM.Size = new System.Drawing.Size(197, 28);
            this.btnPRM.TabIndex = 2;
            this.btnPRM.Text = "Plan Request Monitoring";
            this.btnPRM.UseVisualStyleBackColor = true;
            // 
            // btnPLV
            // 
            this.btnPLV.Location = new System.Drawing.Point(213, 71);
            this.btnPLV.Margin = new System.Windows.Forms.Padding(4);
            this.btnPLV.Name = "btnPLV";
            this.btnPLV.Size = new System.Drawing.Size(197, 28);
            this.btnPLV.TabIndex = 0;
            this.btnPLV.Text = "Plan Location Verification";
            this.btnPLV.UseVisualStyleBackColor = true;
            this.btnPLV.Click += new System.EventHandler(this.btnPLV_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPRM);
            this.Controls.Add(this.btnPLV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "pLaiRes Emulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPRM;
        private System.Windows.Forms.Button btnPLV;

    }
}

