
namespace TheAtlanticBank_Winforms.Forms
{
    partial class Deposit
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
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.processDeposit = new System.Windows.Forms.ProgressBar();
            this.depositBtn = new System.Windows.Forms.Button();
            this.invalidAmt = new System.Windows.Forms.Label();
            this.processingDepositLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Location = new System.Drawing.Point(310, 160);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(280, 26);
            this.amountBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(305, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter deposit amount:";
            // 
            // processDeposit
            // 
            this.processDeposit.Location = new System.Drawing.Point(310, 244);
            this.processDeposit.Name = "processDeposit";
            this.processDeposit.Size = new System.Drawing.Size(280, 11);
            this.processDeposit.TabIndex = 2;
            this.processDeposit.Visible = false;
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.depositBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.depositBtn.ForeColor = System.Drawing.Color.White;
            this.depositBtn.Location = new System.Drawing.Point(400, 206);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(98, 34);
            this.depositBtn.TabIndex = 3;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // invalidAmt
            // 
            this.invalidAmt.AutoSize = true;
            this.invalidAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAmt.ForeColor = System.Drawing.Color.Red;
            this.invalidAmt.Location = new System.Drawing.Point(307, 189);
            this.invalidAmt.Name = "invalidAmt";
            this.invalidAmt.Size = new System.Drawing.Size(0, 17);
            this.invalidAmt.TabIndex = 4;
            // 
            // processingDepositLabel
            // 
            this.processingDepositLabel.AutoSize = true;
            this.processingDepositLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processingDepositLabel.Location = new System.Drawing.Point(429, 267);
            this.processingDepositLabel.Name = "processingDepositLabel";
            this.processingDepositLabel.Size = new System.Drawing.Size(43, 17);
            this.processingDepositLabel.TabIndex = 5;
            this.processingDepositLabel.Text = "label2";
            this.processingDepositLabel.Visible = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.processingDepositLabel);
            this.Controls.Add(this.invalidAmt);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.processDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar processDeposit;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Label invalidAmt;
        private System.Windows.Forms.Label processingDepositLabel;
    }
}