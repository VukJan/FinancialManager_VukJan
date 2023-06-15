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
            this.dgvViewIncome = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewIncome
            // 
            this.dgvViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewIncome.Location = new System.Drawing.Point(12, 54);
            this.dgvViewIncome.Name = "dgvViewIncome";
            this.dgvViewIncome.Size = new System.Drawing.Size(776, 342);
            this.dgvViewIncome.TabIndex = 3;
            this.dgvViewIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewIncome_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(176, 25);
            this.lblSelect.TabIndex = 5;
            this.lblSelect.Text = "Prikaz svih prihoda";
            // 
            // FrmViewIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 447);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvViewIncome);
            this.Name = "FrmViewIncome";
            this.Text = "FrmViewIncome";
            this.Load += new System.EventHandler(this.FrmViewIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvViewIncome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelect;
    }
}