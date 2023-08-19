
namespace TheAtlanticBank_Winforms.Forms
{
    partial class AccountStatement
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
            this.transactionsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // transactionsPanel
            // 
            this.transactionsPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsPanel.Location = new System.Drawing.Point(1, 94);
            this.transactionsPanel.Name = "transactionsPanel";
            this.transactionsPanel.Size = new System.Drawing.Size(880, 370);
            this.transactionsPanel.TabIndex = 0;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.transactionsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel transactionsPanel;
    }
}