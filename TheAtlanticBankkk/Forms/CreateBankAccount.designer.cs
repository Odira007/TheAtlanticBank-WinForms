
namespace TheAtlanticBank_Winforms.Forms
{
    partial class CreateBankAccount
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
            this.desktopPane = new System.Windows.Forms.Panel();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.currentAccount = new System.Windows.Forms.RadioButton();
            this.panelSavings = new System.Windows.Forms.Panel();
            this.savingsAccount = new System.Windows.Forms.RadioButton();
            this.desktopPane.SuspendLayout();
            this.panelCurrent.SuspendLayout();
            this.panelSavings.SuspendLayout();
            this.SuspendLayout();
            // 
            // desktopPane
            // 
            this.desktopPane.BackColor = System.Drawing.Color.Lavender;
            this.desktopPane.Controls.Add(this.createAccountBtn);
            this.desktopPane.Controls.Add(this.label2);
            this.desktopPane.Controls.Add(this.panelCurrent);
            this.desktopPane.Controls.Add(this.panelSavings);
            this.desktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPane.Location = new System.Drawing.Point(0, 0);
            this.desktopPane.Name = "desktopPane";
            this.desktopPane.Size = new System.Drawing.Size(881, 520);
            this.desktopPane.TabIndex = 0;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(320, 361);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(250, 49);
            this.createAccountBtn.TabIndex = 14;
            this.createAccountBtn.Text = "Create bank account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select an account type";
            // 
            // panelCurrent
            // 
            this.panelCurrent.BackgroundImage = global::TheAtlanticBank.Properties.Resources.current;
            this.panelCurrent.Controls.Add(this.currentAccount);
            this.panelCurrent.Location = new System.Drawing.Point(464, 118);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(224, 209);
            this.panelCurrent.TabIndex = 12;
            // 
            // currentAccount
            // 
            this.currentAccount.AutoSize = true;
            this.currentAccount.BackColor = System.Drawing.Color.Transparent;
            this.currentAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAccount.ForeColor = System.Drawing.Color.White;
            this.currentAccount.Location = new System.Drawing.Point(3, 181);
            this.currentAccount.Name = "currentAccount";
            this.currentAccount.Size = new System.Drawing.Size(83, 25);
            this.currentAccount.TabIndex = 0;
            this.currentAccount.TabStop = true;
            this.currentAccount.Text = "Current";
            this.currentAccount.UseVisualStyleBackColor = false;
            this.currentAccount.CheckedChanged += new System.EventHandler(this.currentAccount_CheckedChanged_1);
            // 
            // panelSavings
            // 
            this.panelSavings.BackgroundImage = global::TheAtlanticBank.Properties.Resources.savings;
            this.panelSavings.Controls.Add(this.savingsAccount);
            this.panelSavings.Location = new System.Drawing.Point(185, 118);
            this.panelSavings.Name = "panelSavings";
            this.panelSavings.Size = new System.Drawing.Size(224, 209);
            this.panelSavings.TabIndex = 11;
            // 
            // savingsAccount
            // 
            this.savingsAccount.AutoSize = true;
            this.savingsAccount.BackColor = System.Drawing.Color.Transparent;
            this.savingsAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsAccount.ForeColor = System.Drawing.Color.White;
            this.savingsAccount.Location = new System.Drawing.Point(3, 181);
            this.savingsAccount.Name = "savingsAccount";
            this.savingsAccount.Size = new System.Drawing.Size(83, 25);
            this.savingsAccount.TabIndex = 0;
            this.savingsAccount.TabStop = true;
            this.savingsAccount.Text = "Savings";
            this.savingsAccount.UseVisualStyleBackColor = false;
            this.savingsAccount.CheckedChanged += new System.EventHandler(this.savingsAccount_CheckedChanged_1);
            // 
            // CreateBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.desktopPane);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateBankAccount";
            this.Text = "CreateBankAccount";
            this.desktopPane.ResumeLayout(false);
            this.desktopPane.PerformLayout();
            this.panelCurrent.ResumeLayout(false);
            this.panelCurrent.PerformLayout();
            this.panelSavings.ResumeLayout(false);
            this.panelSavings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel desktopPane;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCurrent;
        private System.Windows.Forms.RadioButton currentAccount;
        private System.Windows.Forms.Panel panelSavings;
        private System.Windows.Forms.RadioButton savingsAccount;
    }
}