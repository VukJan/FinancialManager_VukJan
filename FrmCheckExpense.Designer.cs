namespace FinancialManager_VukJan
{
    partial class FrmCheckExpense
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
            this.lblCheckExpense = new System.Windows.Forms.Label();
            this.dgvCheckExpense = new System.Windows.Forms.DataGridView();
            this.btnCheckExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCheckExpense
            // 
            this.lblCheckExpense.AutoSize = true;
            this.lblCheckExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.lblCheckExpense.Location = new System.Drawing.Point(9, 9);
            this.lblCheckExpense.Name = "lblCheckExpense";
            this.lblCheckExpense.Size = new System.Drawing.Size(121, 15);
            this.lblCheckExpense.TabIndex = 1;
            this.lblCheckExpense.Text = "View of all expenses:";
            // 
            // dgvCheckExpense
            // 
            this.dgvCheckExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckExpense.Location = new System.Drawing.Point(12, 51);
            this.dgvCheckExpense.Name = "dgvCheckExpense";
            this.dgvCheckExpense.Size = new System.Drawing.Size(776, 342);
            this.dgvCheckExpense.TabIndex = 2;
            this.dgvCheckExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckExpense_CellContentClick);
            // 
            // btnCheckExpense
            // 
            this.btnCheckExpense.Location = new System.Drawing.Point(653, 399);
            this.btnCheckExpense.Name = "btnCheckExpense";
            this.btnCheckExpense.Size = new System.Drawing.Size(135, 39);
            this.btnCheckExpense.TabIndex = 3;
            this.btnCheckExpense.Text = "More details!";
            this.btnCheckExpense.UseVisualStyleBackColor = true;
            // 
            // FrmCheckExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckExpense);
            this.Controls.Add(this.dgvCheckExpense);
            this.Controls.Add(this.lblCheckExpense);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmCheckExpense";
            this.Text = "Aplikacija za praćenje financija";
            this.Load += new System.EventHandler(this.FrmCheckExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCheckExpense;
        private System.Windows.Forms.DataGridView dgvCheckExpense;
        private System.Windows.Forms.Button btnCheckExpense;
    }
}