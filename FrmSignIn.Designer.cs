namespace FinancialManager_VukJan
{
    partial class FrmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignIn));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEye = new System.Windows.Forms.Button();
            this.btnEyeclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(273, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Izlaz";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lozinka:";
            // 
            // btnEye
            // 
            this.btnEye.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.Image")));
            this.btnEye.Location = new System.Drawing.Point(221, 51);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(35, 20);
            this.btnEye.TabIndex = 6;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEyeclose
            // 
            this.btnEyeclose.BackColor = System.Drawing.Color.White;
            this.btnEyeclose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEyeclose.Image = ((System.Drawing.Image)(resources.GetObject("btnEyeclose.Image")));
            this.btnEyeclose.Location = new System.Drawing.Point(262, 51);
            this.btnEyeclose.Name = "btnEyeclose";
            this.btnEyeclose.Size = new System.Drawing.Size(27, 20);
            this.btnEyeclose.TabIndex = 7;
            this.btnEyeclose.UseVisualStyleBackColor = false;
            this.btnEyeclose.Click += new System.EventHandler(this.btnEyeclose_Click);
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 126);
            this.Controls.Add(this.btnEyeclose);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Name = "FrmSignIn";
            this.Text = "Aplikacija za praćenje financija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Button btnEyeclose;
    }
}