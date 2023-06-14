namespace FinancialManager_VukJan
{
    partial class FrmUpdateExpenses
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateDate = new System.Windows.Forms.TextBox();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.cbmExpenseName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(665, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtUpdateDate
            // 
            this.txtUpdateDate.Location = new System.Drawing.Point(627, 349);
            this.txtUpdateDate.Name = "txtUpdateDate";
            this.txtUpdateDate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDate.TabIndex = 3;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Location = new System.Drawing.Point(532, 352);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(56, 13);
            this.lblUpdateDate.TabIndex = 5;
            this.lblUpdateDate.Text = "New date:";
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(12, 18);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(93, 13);
            this.lblExpenseName.TabIndex = 6;
            this.lblExpenseName.Text = "Name of expense:";
            // 
            // cbmExpenseName
            // 
            this.cbmExpenseName.FormattingEnabled = true;
            this.cbmExpenseName.Location = new System.Drawing.Point(12, 34);
            this.cbmExpenseName.Name = "cbmExpenseName";
            this.cbmExpenseName.Size = new System.Drawing.Size(135, 21);
            this.cbmExpenseName.TabIndex = 7;
           
            // 
            // FrmUpdateExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbmExpenseName);
            this.Controls.Add(this.lblExpenseName);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.txtUpdateDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmUpdateExpenses";
            this.Text = "FrmUpdateExpenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateDate;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.ComboBox cbmExpenseName;
    }
}