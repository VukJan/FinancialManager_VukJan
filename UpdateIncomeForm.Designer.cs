namespace FinancialManager_VukJan
{
    partial class UpdateIncomeForm
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
            this.txtIncomeDescription = new System.Windows.Forms.TextBox();
            this.lblIncomeDescription = new System.Windows.Forms.Label();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.lblNameIncome = new System.Windows.Forms.Label();
            this.txtIncomeName = new System.Windows.Forms.TextBox();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIncomeDescription
            // 
            this.txtIncomeDescription.Location = new System.Drawing.Point(365, 72);
            this.txtIncomeDescription.Name = "txtIncomeDescription";
            this.txtIncomeDescription.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeDescription.TabIndex = 19;
            // 
            // lblIncomeDescription
            // 
            this.lblIncomeDescription.AutoSize = true;
            this.lblIncomeDescription.Location = new System.Drawing.Point(362, 45);
            this.lblIncomeDescription.Name = "lblIncomeDescription";
            this.lblIncomeDescription.Size = new System.Drawing.Size(60, 13);
            this.lblIncomeDescription.TabIndex = 18;
            this.lblIncomeDescription.Text = "Description";
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(661, 193);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(95, 23);
            this.btnAddIncome.TabIndex = 17;
            this.btnAddIncome.Text = "Update Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // lblNameIncome
            // 
            this.lblNameIncome.AutoSize = true;
            this.lblNameIncome.Location = new System.Drawing.Point(111, 45);
            this.lblNameIncome.Name = "lblNameIncome";
            this.lblNameIncome.Size = new System.Drawing.Size(38, 13);
            this.lblNameIncome.TabIndex = 16;
            this.lblNameIncome.Text = "Name:";
            // 
            // txtIncomeName
            // 
            this.txtIncomeName.Location = new System.Drawing.Point(114, 72);
            this.txtIncomeName.Name = "txtIncomeName";
            this.txtIncomeName.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeName.TabIndex = 14;
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(240, 72);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 12;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(237, 45);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UpdateIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 240);
            this.Controls.Add(this.txtIncomeDescription);
            this.Controls.Add(this.lblIncomeDescription);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.lblNameIncome);
            this.Controls.Add(this.txtIncomeName);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnClose);
            this.Name = "UpdateIncomeForm";
            this.Text = "UpdateIncomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIncomeDescription;
        private System.Windows.Forms.Label lblIncomeDescription;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Label lblNameIncome;
        private System.Windows.Forms.TextBox txtIncomeName;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClose;
    }
}