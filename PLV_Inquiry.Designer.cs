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
            this.components = new System.ComponentModel.Container();
            this.cbxPlanType = new System.Windows.Forms.ComboBox();
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.plairesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plairesDataSet = new PlairesEmulator.PlairesDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plairesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plairesDataSet)).BeginInit();
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
            this.cbxPlanType.Location = new System.Drawing.Point(76, 35);
            this.cbxPlanType.Name = "cbxPlanType";
            this.cbxPlanType.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanType.TabIndex = 0;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(76, 62);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(100, 20);
            this.txtPlanNo.TabIndex = 1;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.DataSource = this.plairesDataSetBindingSource;
            this.dgvResult.Location = new System.Drawing.Point(13, 105);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(346, 184);
            this.dgvResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plan Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plan No:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // plairesDataSetBindingSource
            // 
            this.plairesDataSetBindingSource.DataSource = this.plairesDataSet;
            this.plairesDataSetBindingSource.Position = 0;
            // 
            // plairesDataSet
            // 
            this.plairesDataSet.DataSetName = "PlairesDataSet";
            this.plairesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PLV_Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 312);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.txtPlanNo);
            this.Controls.Add(this.cbxPlanType);
            this.Name = "PLV_Inquiry";
            this.Text = "PLV_Inquiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLV_Inquiry_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plairesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plairesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlanType;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource plairesDataSetBindingSource;
        private PlairesDataSet plairesDataSet;
    }
}