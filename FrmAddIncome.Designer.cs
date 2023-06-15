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
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtIncomeName = new System.Windows.Forms.TextBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.lblIncomeDescription = new System.Windows.Forms.Label();
            this.txtIncomeDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F);
            this.btnClose.Location = new System.Drawing.Point(12, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(234, 66);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 2;
            // 
            // txtIncomeName
            // 
            this.txtIncomeName.Location = new System.Drawing.Point(36, 66);
            this.txtIncomeName.Name = "txtIncomeName";
            this.txtIncomeName.Size = new System.Drawing.Size(150, 20);
            this.txtIncomeName.TabIndex = 4;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F);
            this.btnAddIncome.Location = new System.Drawing.Point(432, 173);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(128, 37);
            this.btnAddIncome.TabIndex = 7;
            this.btnAddIncome.Text = "Dodaj Prihod";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // lblIncomeDescription
            // 
            this.lblIncomeDescription.AutoSize = true;
            this.lblIncomeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeDescription.Location = new System.Drawing.Point(420, 39);
            this.lblIncomeDescription.Name = "lblIncomeDescription";
            this.lblIncomeDescription.Size = new System.Drawing.Size(94, 18);
            this.lblIncomeDescription.TabIndex = 8;
            this.lblIncomeDescription.Text = "Kratki opis:";
            // 
            // txtIncomeDescription
            // 
            this.txtIncomeDescription.Location = new System.Drawing.Point(391, 66);
            this.txtIncomeDescription.Name = "txtIncomeDescription";
            this.txtIncomeDescription.Size = new System.Drawing.Size(169, 20);
            this.txtIncomeDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Iznos prihoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv:";
            // 
            // FrmAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIncomeDescription);
            this.Controls.Add(this.lblIncomeDescription);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.txtIncomeName);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmAddIncome";
            this.Text = "FrmPaycheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtIncomeName;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Label lblIncomeDescription;
        private System.Windows.Forms.TextBox txtIncomeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}