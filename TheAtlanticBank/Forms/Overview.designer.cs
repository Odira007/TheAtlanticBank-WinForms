
namespace TheAtlanticBank_Winforms.Forms
{
    partial class Overview
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
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accountInUse = new System.Windows.Forms.Label();
            this.accNumber = new System.Windows.Forms.Label();
            this.invalidSelection = new System.Windows.Forms.Label();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsPanel
            // 
            this.accountsPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsPanel.Location = new System.Drawing.Point(1, 77);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(882, 220);
            this.accountsPanel.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.welcomeLabel.Location = new System.Drawing.Point(11, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(156, 37);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, ";
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Location = new System.Drawing.Point(1, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(882, 80);
            this.welcomePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter an account ID to select an account:";
            // 
            // selection
            // 
            this.selection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.selection.Location = new System.Drawing.Point(326, 316);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(97, 22);
            this.selection.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(375, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountInUse
            // 
            this.accountInUse.AutoSize = true;
            this.accountInUse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInUse.Location = new System.Drawing.Point(14, 419);
            this.accountInUse.Name = "accountInUse";
            this.accountInUse.Size = new System.Drawing.Size(239, 25);
            this.accountInUse.TabIndex = 5;
            this.accountInUse.Text = "Account currently in use: ";
            // 
            // accNumber
            // 
            this.accNumber.AutoSize = true;
            this.accNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.accNumber.Location = new System.Drawing.Point(245, 419);
            this.accNumber.Name = "accNumber";
            this.accNumber.Size = new System.Drawing.Size(17, 25);
            this.accNumber.TabIndex = 6;
            this.accNumber.Text = " ";
            // 
            // invalidSelection
            // 
            this.invalidSelection.AutoSize = true;
            this.invalidSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidSelection.ForeColor = System.Drawing.Color.Red;
            this.invalidSelection.Location = new System.Drawing.Point(323, 341);
            this.invalidSelection.Name = "invalidSelection";
            this.invalidSelection.Size = new System.Drawing.Size(43, 17);
            this.invalidSelection.TabIndex = 7;
            this.invalidSelection.Text = "label2";
            this.invalidSelection.Visible = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.invalidSelection);
            this.Controls.Add(this.accNumber);
            this.Controls.Add(this.accountInUse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.welcomePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Overview";
            this.Text = "Overview";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel accountsPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label accountInUse;
        private System.Windows.Forms.Label accNumber;
        private System.Windows.Forms.Label invalidSelection;
    }
}