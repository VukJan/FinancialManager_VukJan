namespace FinancialManager_VukJan
{
    partial class FrmIncomeXOutcome
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
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.dgvOutcome = new System.Windows.Forms.DataGridView();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalOutcome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(3, 44);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(240, 150);
            this.dgvIncome.TabIndex = 1;
            // 
            // dgvOutcome
            // 
            this.dgvOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutcome.Location = new System.Drawing.Point(484, 44);
            this.dgvOutcome.Name = "dgvOutcome";
            this.dgvOutcome.Size = new System.Drawing.Size(240, 150);
            this.dgvOutcome.TabIndex = 2;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(9, 203);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(34, 13);
            this.lblTotalIncome.TabIndex = 3;
            this.lblTotalIncome.Text = "Total:";
            // 
            // lblTotalOutcome
            // 
            this.lblTotalOutcome.AutoSize = true;
            this.lblTotalOutcome.Location = new System.Drawing.Point(490, 203);
            this.lblTotalOutcome.Name = "lblTotalOutcome";
            this.lblTotalOutcome.Size = new System.Drawing.Size(34, 13);
            this.lblTotalOutcome.TabIndex = 4;
            this.lblTotalOutcome.Text = "Total:";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(63, 200);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 5;
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(577, 200);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(100, 20);
            this.txtOutcome.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotal.Location = new System.Drawing.Point(259, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Result:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(329, 246);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(12, 19);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(45, 13);
            this.lblIncome.TabIndex = 9;
            this.lblIncome.Text = "Income:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(574, 19);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(56, 13);
            this.lblOutcome.TabIndex = 10;
            this.lblOutcome.Text = "Expenses:";
            // 
            // FrmIncomeXOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lblTotalOutcome);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.dgvOutcome);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmIncomeXOutcome";
            this.Text = "IncomeXOutcome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.DataGridView dgvOutcome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalOutcome;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutcome;
    }
}