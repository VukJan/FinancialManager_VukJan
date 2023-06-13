namespace FinancialManager_VukJan
{
    partial class FrmViewIncome
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
            this.lblViewIncome = new System.Windows.Forms.Label();
            this.dgvViewIncome = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewIncome
            // 
            this.lblViewIncome.AutoSize = true;
            this.lblViewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.lblViewIncome.Location = new System.Drawing.Point(12, 9);
            this.lblViewIncome.Name = "lblViewIncome";
            this.lblViewIncome.Size = new System.Drawing.Size(106, 15);
            this.lblViewIncome.TabIndex = 2;
            this.lblViewIncome.Text = "View of all Income";
            // 
            // dgvViewIncome
            // 
            this.dgvViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewIncome.Location = new System.Drawing.Point(12, 54);
            this.dgvViewIncome.Name = "dgvViewIncome";
            this.dgvViewIncome.Size = new System.Drawing.Size(776, 342);
            this.dgvViewIncome.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.Location = new System.Drawing.Point(653, 399);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(135, 39);
            this.btnViewIncome.TabIndex = 5;
            this.btnViewIncome.Text = "More details!";
            this.btnViewIncome.UseVisualStyleBackColor = true;
            // 
            // FrmViewIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvViewIncome);
            this.Controls.Add(this.lblViewIncome);
            this.Name = "FrmViewIncome";
            this.Text = "FrmViewIncome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewIncome;
        private System.Windows.Forms.DataGridView dgvViewIncome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewIncome;
    }
}