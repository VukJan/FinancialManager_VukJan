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
            this.dgvCurrent = new System.Windows.Forms.DataGridView();
            this.btnInsertIncome = new System.Windows.Forms.Button();
            this.btnIXO = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.btnUpdateIncome = new System.Windows.Forms.Button();
            this.btnDeleteIncome = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertExpense
            // 
            this.btnInsertExpense.Location = new System.Drawing.Point(256, 69);
            this.btnInsertExpense.Name = "btnInsertExpense";
            this.btnInsertExpense.Size = new System.Drawing.Size(126, 48);
            this.btnInsertExpense.TabIndex = 1;
            this.btnInsertExpense.Text = "Dodaj trošak";
            this.btnInsertExpense.UseVisualStyleBackColor = true;
            this.btnInsertExpense.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Location = new System.Drawing.Point(256, 133);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(126, 46);
            this.btnViewExpense.TabIndex = 2;
            this.btnViewExpense.Text = "Pregledaj troškove";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnCheckExpense_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Location = new System.Drawing.Point(258, 262);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(124, 45);
            this.btnDeleteExpense.TabIndex = 3;
            this.btnDeleteExpense.Text = "Izbriši trosak";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.Location = new System.Drawing.Point(256, 195);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(126, 46);
            this.btnUpdateExpense.TabIndex = 4;
            this.btnUpdateExpense.Text = "Ažuriraj troškove";
            this.btnUpdateExpense.UseVisualStyleBackColor = true;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // dgvCurrent
            // 
            this.dgvCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrent.Location = new System.Drawing.Point(506, 52);
            this.dgvCurrent.Name = "dgvCurrent";
            this.dgvCurrent.Size = new System.Drawing.Size(142, 282);
            this.dgvCurrent.TabIndex = 6;
            // 
            // btnInsertIncome
            // 
            this.btnInsertIncome.Location = new System.Drawing.Point(45, 69);
            this.btnInsertIncome.Name = "btnInsertIncome";
            this.btnInsertIncome.Size = new System.Drawing.Size(124, 48);
            this.btnInsertIncome.TabIndex = 7;
            this.btnInsertIncome.Text = "Dodaj prihod";
            this.btnInsertIncome.UseVisualStyleBackColor = true;
            this.btnInsertIncome.Click += new System.EventHandler(this.btnPaycheck_Click);
            // 
            // btnIXO
            // 
            this.btnIXO.Location = new System.Drawing.Point(476, 351);
            this.btnIXO.Name = "btnIXO";
            this.btnIXO.Size = new System.Drawing.Size(204, 44);
            this.btnIXO.TabIndex = 8;
            this.btnIXO.Text = "Prihod X Trošak - detalji";
            this.btnIXO.UseVisualStyleBackColor = true;
            this.btnIXO.Click += new System.EventHandler(this.btnIXO_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.Location = new System.Drawing.Point(45, 133);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(124, 46);
            this.btnViewIncome.TabIndex = 9;
            this.btnViewIncome.Text = "Pregledaj prihode";
            this.btnViewIncome.UseVisualStyleBackColor = true;
            this.btnViewIncome.Click += new System.EventHandler(this.btnViewIncome_Click);
            // 
            // btnUpdateIncome
            // 
            this.btnUpdateIncome.Location = new System.Drawing.Point(45, 195);
            this.btnUpdateIncome.Name = "btnUpdateIncome";
            this.btnUpdateIncome.Size = new System.Drawing.Size(124, 46);
            this.btnUpdateIncome.TabIndex = 10;
            this.btnUpdateIncome.Text = "Ažuriraj prihode";
            this.btnUpdateIncome.UseVisualStyleBackColor = true;
            this.btnUpdateIncome.Click += new System.EventHandler(this.btnUpdateIncome_Click);
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.Location = new System.Drawing.Point(45, 262);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(124, 45);
            this.btnDeleteIncome.TabIndex = 11;
            this.btnDeleteIncome.Text = "Izbriši prihod";
            this.btnDeleteIncome.UseVisualStyleBackColor = true;
            this.btnDeleteIncome.Click += new System.EventHandler(this.btnDeleteIncome_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(7, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(144, 25);
            this.lblSelect.TabIndex = 13;
            this.lblSelect.Text = "Odaberi opciju:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trenutni troškovi:";
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnDeleteIncome);
            this.Controls.Add(this.btnUpdateIncome);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnIXO);
            this.Controls.Add(this.btnInsertIncome);
            this.Controls.Add(this.dgvCurrent);
            this.Controls.Add(this.btnUpdateExpense);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.btnInsertExpense);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmSystem";
            this.Text = "Aplikacija za praćenje financija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSystem_FormClosing);
            this.Load += new System.EventHandler(this.FrmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsertExpense;
        private System.Windows.Forms.Button btnViewExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.DataGridView dgvCurrent;
        private System.Windows.Forms.Button btnInsertIncome;
        private System.Windows.Forms.Button btnIXO;
        private System.Windows.Forms.Button btnViewIncome;
        private System.Windows.Forms.Button btnUpdateIncome;
        private System.Windows.Forms.Button btnDeleteIncome;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label1;
    }
}