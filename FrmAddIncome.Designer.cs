namespace FinancialManager_VukJan
{
    partial class FrmAddIncome
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtIncomeDate = new System.Windows.Forms.TextBox();
            this.txtIncomeName = new System.Windows.Forms.TextBox();
            this.lblDateIncome = new System.Windows.Forms.Label();
            this.lblNameIncome = new System.Windows.Forms.Label();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.lblIncomeDescription = new System.Windows.Forms.Label();
            this.txtIncomeDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-7, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(209, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(212, 66);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 2;
            // 
            // txtIncomeDate
            // 
            this.txtIncomeDate.Location = new System.Drawing.Point(460, 66);
            this.txtIncomeDate.Name = "txtIncomeDate";
            this.txtIncomeDate.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeDate.TabIndex = 3;
            // 
            // txtIncomeName
            // 
            this.txtIncomeName.Location = new System.Drawing.Point(86, 66);
            this.txtIncomeName.Name = "txtIncomeName";
            this.txtIncomeName.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeName.TabIndex = 4;
            // 
            // lblDateIncome
            // 
            this.lblDateIncome.AutoSize = true;
            this.lblDateIncome.Location = new System.Drawing.Point(466, 39);
            this.lblDateIncome.Name = "lblDateIncome";
            this.lblDateIncome.Size = new System.Drawing.Size(80, 13);
            this.lblDateIncome.TabIndex = 5;
            this.lblDateIncome.Text = "Date of adding:";
            // 
            // lblNameIncome
            // 
            this.lblNameIncome.AutoSize = true;
            this.lblNameIncome.Location = new System.Drawing.Point(83, 39);
            this.lblNameIncome.Name = "lblNameIncome";
            this.lblNameIncome.Size = new System.Drawing.Size(38, 13);
            this.lblNameIncome.TabIndex = 6;
            this.lblNameIncome.Text = "Name:";
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(653, 187);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(75, 23);
            this.btnAddIncome.TabIndex = 7;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            // 
            // lblIncomeDescription
            // 
            this.lblIncomeDescription.AutoSize = true;
            this.lblIncomeDescription.Location = new System.Drawing.Point(334, 39);
            this.lblIncomeDescription.Name = "lblIncomeDescription";
            this.lblIncomeDescription.Size = new System.Drawing.Size(60, 13);
            this.lblIncomeDescription.TabIndex = 8;
            this.lblIncomeDescription.Text = "Description";
            // 
            // txtIncomeDescription
            // 
            this.txtIncomeDescription.Location = new System.Drawing.Point(337, 66);
            this.txtIncomeDescription.Name = "txtIncomeDescription";
            this.txtIncomeDescription.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeDescription.TabIndex = 9;
            // 
            // FrmAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 226);
            this.Controls.Add(this.txtIncomeDescription);
            this.Controls.Add(this.lblIncomeDescription);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.lblNameIncome);
            this.Controls.Add(this.lblDateIncome);
            this.Controls.Add(this.txtIncomeName);
            this.Controls.Add(this.txtIncomeDate);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmAddIncome";
            this.Text = "FrmPaycheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtIncomeDate;
        private System.Windows.Forms.TextBox txtIncomeName;
        private System.Windows.Forms.Label lblDateIncome;
        private System.Windows.Forms.Label lblNameIncome;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Label lblIncomeDescription;
        private System.Windows.Forms.TextBox txtIncomeDescription;
    }
}