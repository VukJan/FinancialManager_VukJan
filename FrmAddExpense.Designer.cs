namespace FinancialManager_VukJan
{
    partial class FrmAddExpense
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
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.cbmNeeded = new System.Windows.Forms.ComboBox();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.lblIncomeDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(185, 78);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(119, 20);
            this.txtExpenseAmount.TabIndex = 6;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(27, 78);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(125, 20);
            this.txtExpenseName.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F);
            this.btnAddExpense.Location = new System.Drawing.Point(633, 175);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(125, 31);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "Dodaj trošak";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbmNeeded
            // 
            this.cbmNeeded.FormattingEnabled = true;
            this.cbmNeeded.Location = new System.Drawing.Point(586, 77);
            this.cbmNeeded.Name = "cbmNeeded";
            this.cbmNeeded.Size = new System.Drawing.Size(103, 21);
            this.cbmNeeded.TabIndex = 10;
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(332, 78);
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.Size = new System.Drawing.Size(181, 20);
            this.txtExpenseDescription.TabIndex = 12;
            // 
            // lblIncomeDescription
            // 
            this.lblIncomeDescription.AutoSize = true;
            this.lblIncomeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeDescription.Location = new System.Drawing.Point(583, 46);
            this.lblIncomeDescription.Name = "lblIncomeDescription";
            this.lblIncomeDescription.Size = new System.Drawing.Size(147, 18);
            this.lblIncomeDescription.TabIndex = 13;
            this.lblIncomeDescription.Text = "Je li bio potreban?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kratki opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Iznos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Naziv:";
            // 
            // FrmAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIncomeDescription);
            this.Controls.Add(this.txtExpenseDescription);
            this.Controls.Add(this.cbmNeeded);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.txtExpenseAmount);
            this.Name = "FrmAddExpense";
            this.Text = "Aplikacija za praćenje financija";
            this.Load += new System.EventHandler(this.FrmAddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ComboBox cbmNeeded;
        private System.Windows.Forms.TextBox txtExpenseDescription;
        private System.Windows.Forms.Label lblIncomeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}