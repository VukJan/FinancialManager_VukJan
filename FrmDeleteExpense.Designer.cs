namespace FinancialManager_VukJan
{
    partial class FrmDeleteExpense
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.cbmExpenseID = new System.Windows.Forms.ComboBox();
            this.cbmExpensePrice = new System.Windows.Forms.ComboBox();
            this.cbmExpenseName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 19);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(140, 25);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Odaberi trošak";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Naziv:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(24, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Iznos troška:";
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Location = new System.Drawing.Point(397, 230);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(113, 38);
            this.btnDeleteExpense.TabIndex = 10;
            this.btnDeleteExpense.Text = "Izbriši trošak!";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbmExpenseID
            // 
            this.cbmExpenseID.FormattingEnabled = true;
            this.cbmExpenseID.Location = new System.Drawing.Point(97, 69);
            this.cbmExpenseID.Name = "cbmExpenseID";
            this.cbmExpenseID.Size = new System.Drawing.Size(208, 21);
            this.cbmExpenseID.TabIndex = 12;
            // 
            // cbmExpensePrice
            // 
            this.cbmExpensePrice.FormattingEnabled = true;
            this.cbmExpensePrice.Location = new System.Drawing.Point(97, 121);
            this.cbmExpensePrice.Name = "cbmExpensePrice";
            this.cbmExpensePrice.Size = new System.Drawing.Size(208, 21);
            this.cbmExpensePrice.TabIndex = 14;
            // 
            // cbmExpenseName
            // 
            this.cbmExpenseName.FormattingEnabled = true;
            this.cbmExpenseName.Location = new System.Drawing.Point(97, 96);
            this.cbmExpenseName.Name = "cbmExpenseName";
            this.cbmExpenseName.Size = new System.Drawing.Size(208, 21);
            this.cbmExpenseName.TabIndex = 15;
            // 
            // FrmDeleteExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 275);
            this.Controls.Add(this.cbmExpenseName);
            this.Controls.Add(this.cbmExpensePrice);
            this.Controls.Add(this.cbmExpenseID);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmDeleteExpense";
            this.Text = "Aplikacija za praćenje financija";
            this.Load += new System.EventHandler(this.FrmDeleteExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.ComboBox cbmExpenseID;
        private System.Windows.Forms.ComboBox cbmExpensePrice;
        private System.Windows.Forms.ComboBox cbmExpenseName;
    }
}