
namespace TheAtlanticBank_Winforms.Forms
{
    partial class Dashboard
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
            this.navBar = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.accountStatement = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.overview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.accountView = new System.Windows.Forms.Panel();
            this.CreateBankAccount = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.White;
            this.navBar.Controls.Add(this.CreateBankAccount);
            this.navBar.Controls.Add(this.logOut);
            this.navBar.Controls.Add(this.accountStatement);
            this.navBar.Controls.Add(this.transfer);
            this.navBar.Controls.Add(this.withdraw);
            this.navBar.Controls.Add(this.deposit);
            this.navBar.Controls.Add(this.overview);
            this.navBar.Controls.Add(this.panel2);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(200, 520);
            this.navBar.TabIndex = 0;
            // 
            // logOut
            // 
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.logOut.Location = new System.Drawing.Point(0, 409);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(200, 60);
            this.logOut.TabIndex = 6;
            this.logOut.Text = "Log out";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // accountStatement
            // 
            this.accountStatement.FlatAppearance.BorderSize = 0;
            this.accountStatement.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.accountStatement.Location = new System.Drawing.Point(0, 295);
            this.accountStatement.Name = "accountStatement";
            this.accountStatement.Size = new System.Drawing.Size(200, 60);
            this.accountStatement.TabIndex = 5;
            this.accountStatement.Text = "Account statement";
            this.accountStatement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountStatement.UseVisualStyleBackColor = true;
            this.accountStatement.Click += new System.EventHandler(this.accountStatement_Click);
            // 
            // transfer
            // 
            this.transfer.FlatAppearance.BorderSize = 0;
            this.transfer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.transfer.Location = new System.Drawing.Point(0, 238);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(200, 60);
            this.transfer.TabIndex = 4;
            this.transfer.Text = "Send money";
            this.transfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // withdraw
            // 
            this.withdraw.FlatAppearance.BorderSize = 0;
            this.withdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.withdraw.Location = new System.Drawing.Point(0, 181);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(200, 60);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "Withdraw";
            this.withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.deposit.Location = new System.Drawing.Point(0, 124);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(200, 60);
            this.deposit.TabIndex = 2;
            this.deposit.Text = "Deposit";
            this.deposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // overview
            // 
            this.overview.FlatAppearance.BorderSize = 0;
            this.overview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.overview.Location = new System.Drawing.Point(0, 67);
            this.overview.Name = "overview";
            this.overview.Size = new System.Drawing.Size(200, 60);
            this.overview.TabIndex = 1;
            this.overview.Text = "Overview";
            this.overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overview.UseVisualStyleBackColor = true;
            this.overview.Click += new System.EventHandler(this.overview_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.logo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.logo.Location = new System.Drawing.Point(24, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 25);
            this.logo.TabIndex = 0;
            this.logo.Text = "TheAtlanticBank";
            // 
            // accountView
            // 
            this.accountView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountView.Location = new System.Drawing.Point(200, 0);
            this.accountView.Name = "accountView";
            this.accountView.Size = new System.Drawing.Size(681, 520);
            this.accountView.TabIndex = 1;
            // 
            // CreateBankAccount
            // 
            this.CreateBankAccount.FlatAppearance.BorderSize = 0;
            this.CreateBankAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBankAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.CreateBankAccount.Location = new System.Drawing.Point(0, 352);
            this.CreateBankAccount.Name = "CreateBankAccount";
            this.CreateBankAccount.Size = new System.Drawing.Size(200, 60);
            this.CreateBankAccount.TabIndex = 7;
            this.CreateBankAccount.Text = "Create new bank account";
            this.CreateBankAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBankAccount.UseVisualStyleBackColor = true;
            this.CreateBankAccount.Click += new System.EventHandler(this.CreateBankAccount_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.accountView);
            this.Controls.Add(this.navBar);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.navBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button accountStatement;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button overview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel accountView;
        private System.Windows.Forms.Button CreateBankAccount;
    }
}