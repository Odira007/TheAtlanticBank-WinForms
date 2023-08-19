
namespace TheAtlanticBank_Winforms
{
    partial class LoginSect
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
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invalid1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.sideImage = new System.Windows.Forms.Panel();
            this.desktopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // desktopPanel
            // 
            this.desktopPanel.Controls.Add(this.panel1);
            this.desktopPanel.Controls.Add(this.sideImage);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(6);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(881, 520);
            this.desktopPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.invalid1);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(519, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 520);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "TheAtlanticBank";
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.registerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.registerBtn.Location = new System.Drawing.Point(217, 321);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(60, 19);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account?";
            // 
            // invalid1
            // 
            this.invalid1.AutoSize = true;
            this.invalid1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid1.ForeColor = System.Drawing.Color.Red;
            this.invalid1.Location = new System.Drawing.Point(73, 251);
            this.invalid1.Name = "invalid1";
            this.invalid1.Size = new System.Drawing.Size(158, 17);
            this.invalid1.TabIndex = 5;
            this.invalid1.Text = "Invalid email or password";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(76, 279);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(209, 39);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.labelPassword.Location = new System.Drawing.Point(72, 204);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 19);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.labelEmail.Location = new System.Drawing.Point(72, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 19);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Location = new System.Drawing.Point(76, 226);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(209, 22);
            this.password.TabIndex = 1;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Location = new System.Drawing.Point(76, 172);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(209, 22);
            this.email.TabIndex = 0;
            // 
            // sideImage
            // 
            this.sideImage.BackgroundImage = global::TheAtlanticBank.Properties.Resources.tab3;
            this.sideImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideImage.Location = new System.Drawing.Point(0, 0);
            this.sideImage.Name = "sideImage";
            this.sideImage.Size = new System.Drawing.Size(513, 520);
            this.sideImage.TabIndex = 0;
            // 
            // LoginSect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.desktopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginSect";
            this.Text = "LoginSect";
            this.desktopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Panel sideImage;
        private System.Windows.Forms.Label invalid1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label registerBtn;
        private System.Windows.Forms.Label label1;
    }
}