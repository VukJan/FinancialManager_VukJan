namespace FinancialManager_VukJan
{
    partial class FrmDeleteIncome
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbmIncomeID = new System.Windows.Forms.ComboBox();
            this.cbmIncomeName = new System.Windows.Forms.ComboBox();
            this.cbmIncomePrice = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(29, 24);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(140, 25);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Odaberi trošak";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 98);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(31, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // cbmIncomeID
            // 
            this.cbmIncomeID.FormattingEnabled = true;
            this.cbmIncomeID.Location = new System.Drawing.Point(91, 95);
            this.cbmIncomeID.Name = "cbmIncomeID";
            this.cbmIncomeID.Size = new System.Drawing.Size(208, 21);
            this.cbmIncomeID.TabIndex = 13;
            // 
            // cbmIncomeName
            // 
            this.cbmIncomeName.FormattingEnabled = true;
            this.cbmIncomeName.Location = new System.Drawing.Point(91, 122);
            this.cbmIncomeName.Name = "cbmIncomeName";
            this.cbmIncomeName.Size = new System.Drawing.Size(208, 21);
            this.cbmIncomeName.TabIndex = 16;
            // 
            // cbmIncomePrice
            // 
            this.cbmIncomePrice.FormattingEnabled = true;
            this.cbmIncomePrice.Location = new System.Drawing.Point(91, 149);
            this.cbmIncomePrice.Name = "cbmIncomePrice";
            this.cbmIncomePrice.Size = new System.Drawing.Size(208, 21);
            this.cbmIncomePrice.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.Location = new System.Drawing.Point(482, 283);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteIncome.TabIndex = 19;
            this.btnDeleteIncome.Text = "Delete Income";
            this.btnDeleteIncome.UseVisualStyleBackColor = true;
            this.btnDeleteIncome.Click += new System.EventHandler(this.btnDeleteIncome_Click);
            // 
            // FrmDeleteIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 318);
            this.Controls.Add(this.btnDeleteIncome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbmIncomePrice);
            this.Controls.Add(this.cbmIncomeName);
            this.Controls.Add(this.cbmIncomeID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSelect);
            this.Name = "FrmDeleteIncome";
            this.Text = "FrmDeleteIncome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbmIncomeID;
        private System.Windows.Forms.ComboBox cbmIncomeName;
        private System.Windows.Forms.ComboBox cbmIncomePrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteIncome;
    }
}