namespace LoginSistem
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.txtboxUserNameLogin = new System.Windows.Forms.TextBox();
            this.txtboxPasswordLoginDirector = new System.Windows.Forms.TextBox();
            this.lblUserNameLogin = new System.Windows.Forms.Label();
            this.lblPwLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCloseLoginDirector = new System.Windows.Forms.Button();
            this.lblWelcomeDirector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(295, 105);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(105, 40);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login/";
            // 
            // llblRegister
            // 
            this.llblRegister.AutoSize = true;
            this.llblRegister.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegister.LinkColor = System.Drawing.Color.Black;
            this.llblRegister.Location = new System.Drawing.Point(396, 105);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(130, 40);
            this.llblRegister.TabIndex = 1;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "Register";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // txtboxUserNameLogin
            // 
            this.txtboxUserNameLogin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUserNameLogin.Location = new System.Drawing.Point(270, 202);
            this.txtboxUserNameLogin.Name = "txtboxUserNameLogin";
            this.txtboxUserNameLogin.Size = new System.Drawing.Size(278, 36);
            this.txtboxUserNameLogin.TabIndex = 2;
            // 
            // txtboxPasswordLoginDirector
            // 
            this.txtboxPasswordLoginDirector.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPasswordLoginDirector.Location = new System.Drawing.Point(270, 291);
            this.txtboxPasswordLoginDirector.Name = "txtboxPasswordLoginDirector";
            this.txtboxPasswordLoginDirector.PasswordChar = '*';
            this.txtboxPasswordLoginDirector.Size = new System.Drawing.Size(278, 36);
            this.txtboxPasswordLoginDirector.TabIndex = 3;
            // 
            // lblUserNameLogin
            // 
            this.lblUserNameLogin.AutoSize = true;
            this.lblUserNameLogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameLogin.Location = new System.Drawing.Point(341, 164);
            this.lblUserNameLogin.Name = "lblUserNameLogin";
            this.lblUserNameLogin.Size = new System.Drawing.Size(137, 35);
            this.lblUserNameLogin.TabIndex = 4;
            this.lblUserNameLogin.Text = "UserName";
            // 
            // lblPwLogin
            // 
            this.lblPwLogin.AutoSize = true;
            this.lblPwLogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwLogin.Location = new System.Drawing.Point(349, 253);
            this.lblPwLogin.Name = "lblPwLogin";
            this.lblPwLogin.Size = new System.Drawing.Size(126, 35);
            this.lblPwLogin.TabIndex = 5;
            this.lblPwLogin.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(212, 349);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 61);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCloseLoginDirector
            // 
            this.btnCloseLoginDirector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseLoginDirector.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginDirector.Location = new System.Drawing.Point(464, 349);
            this.btnCloseLoginDirector.Name = "btnCloseLoginDirector";
            this.btnCloseLoginDirector.Size = new System.Drawing.Size(137, 61);
            this.btnCloseLoginDirector.TabIndex = 7;
            this.btnCloseLoginDirector.Text = "Close";
            this.btnCloseLoginDirector.UseVisualStyleBackColor = false;
            this.btnCloseLoginDirector.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // lblWelcomeDirector
            // 
            this.lblWelcomeDirector.AutoSize = true;
            this.lblWelcomeDirector.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDirector.Location = new System.Drawing.Point(262, 9);
            this.lblWelcomeDirector.Name = "lblWelcomeDirector";
            this.lblWelcomeDirector.Size = new System.Drawing.Size(305, 46);
            this.lblWelcomeDirector.TabIndex = 8;
            this.lblWelcomeDirector.Text = "Welcome Director";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.lblWelcomeDirector);
            this.Controls.Add(this.btnCloseLoginDirector);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPwLogin);
            this.Controls.Add(this.lblUserNameLogin);
            this.Controls.Add(this.txtboxPasswordLoginDirector);
            this.Controls.Add(this.txtboxUserNameLogin);
            this.Controls.Add(this.llblRegister);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.Text = "DirectorLogin";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.TextBox txtboxUserNameLogin;
        private System.Windows.Forms.TextBox txtboxPasswordLoginDirector;
        private System.Windows.Forms.Label lblUserNameLogin;
        private System.Windows.Forms.Label lblPwLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCloseLoginDirector;
        private System.Windows.Forms.Label lblWelcomeDirector;
    }
}