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
            this.dgvCheckExpense = new System.Windows.Forms.DataGridView();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(185, 25);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Prikaz svih troškova";
            // 
            // FrmCheckExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.dgvCheckExpense);
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
        private System.Windows.Forms.DataGridView dgvCheckExpense;
        private System.Windows.Forms.Label lblSelect;
    }
}