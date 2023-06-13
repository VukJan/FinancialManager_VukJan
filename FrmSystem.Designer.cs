namespace FinancialManager_VukJan
{
    partial class FrmSystem
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
            this.btnInsertExpense = new System.Windows.Forms.Button();
            this.btnViewExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertIncome = new System.Windows.Forms.Button();
            this.btnIXO = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.btnUpdateIncome = new System.Windows.Forms.Button();
            this.btnDeleteIncome = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertExpense
            // 
            this.btnInsertExpense.Location = new System.Drawing.Point(45, 64);
            this.btnInsertExpense.Name = "btnInsertExpense";
            this.btnInsertExpense.Size = new System.Drawing.Size(124, 23);
            this.btnInsertExpense.TabIndex = 1;
            this.btnInsertExpense.Text = "Add expense";
            this.btnInsertExpense.UseVisualStyleBackColor = true;
            this.btnInsertExpense.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Location = new System.Drawing.Point(45, 105);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(124, 23);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "View Expenses";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnCheckExpense_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Location = new System.Drawing.Point(45, 182);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteExpense.TabIndex = 3;
            this.btnDeleteExpense.Text = "Delete expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.Location = new System.Drawing.Point(45, 143);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(124, 23);
            this.btnUpdateExpense.TabIndex = 4;
            this.btnUpdateExpense.Text = "Update expense";
            this.btnUpdateExpense.UseVisualStyleBackColor = true;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Location = new System.Drawing.Point(531, 23);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(93, 13);
            this.lblExpenses.TabIndex = 5;
            this.lblExpenses.Text = "Current Expenses:";
            this.lblExpenses.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnInsertIncome
            // 
            this.btnInsertIncome.Location = new System.Drawing.Point(191, 64);
            this.btnInsertIncome.Name = "btnInsertIncome";
            this.btnInsertIncome.Size = new System.Drawing.Size(124, 23);
            this.btnInsertIncome.TabIndex = 7;
            this.btnInsertIncome.Text = "Add Income";
            this.btnInsertIncome.UseVisualStyleBackColor = true;
            this.btnInsertIncome.Click += new System.EventHandler(this.btnPaycheck_Click);
            // 
            // btnIXO
            // 
            this.btnIXO.Location = new System.Drawing.Point(502, 211);
            this.btnIXO.Name = "btnIXO";
            this.btnIXO.Size = new System.Drawing.Size(150, 23);
            this.btnIXO.TabIndex = 8;
            this.btnIXO.Text = "Income X Outcome - details";
            this.btnIXO.UseVisualStyleBackColor = true;
            this.btnIXO.Click += new System.EventHandler(this.btnIXO_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.Location = new System.Drawing.Point(191, 105);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(124, 23);
            this.btnViewIncome.TabIndex = 9;
            this.btnViewIncome.Text = "View Total Income";
            this.btnViewIncome.UseVisualStyleBackColor = true;
            this.btnViewIncome.Click += new System.EventHandler(this.btnViewIncome_Click);
            // 
            // btnUpdateIncome
            // 
            this.btnUpdateIncome.Location = new System.Drawing.Point(191, 143);
            this.btnUpdateIncome.Name = "btnUpdateIncome";
            this.btnUpdateIncome.Size = new System.Drawing.Size(124, 23);
            this.btnUpdateIncome.TabIndex = 10;
            this.btnUpdateIncome.Text = "Update Income row";
            this.btnUpdateIncome.UseVisualStyleBackColor = true;
            this.btnUpdateIncome.Click += new System.EventHandler(this.btnUpdateIncome_Click);
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.Location = new System.Drawing.Point(191, 182);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteIncome.TabIndex = 11;
            this.btnDeleteIncome.Text = "Delete income row";
            this.btnDeleteIncome.UseVisualStyleBackColor = true;
            this.btnDeleteIncome.Click += new System.EventHandler(this.btnDeleteIncome_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(42, 23);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(93, 13);
            this.lblOptions.TabIndex = 12;
            this.lblOptions.Text = "Choose an option:";
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 293);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnDeleteIncome);
            this.Controls.Add(this.btnUpdateIncome);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnIXO);
            this.Controls.Add(this.btnInsertIncome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.btnUpdateExpense);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.btnInsertExpense);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmSystem";
            this.Text = "Aplikacija za praćenje financija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSystem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsertExpense;
        private System.Windows.Forms.Button btnViewExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertIncome;
        private System.Windows.Forms.Button btnIXO;
        private System.Windows.Forms.Button btnViewIncome;
        private System.Windows.Forms.Button btnUpdateIncome;
        private System.Windows.Forms.Button btnDeleteIncome;
        private System.Windows.Forms.Label lblOptions;
    }
}