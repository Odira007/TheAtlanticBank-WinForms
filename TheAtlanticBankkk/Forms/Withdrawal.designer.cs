
namespace TheAtlanticBank_Winforms.Forms
{
    partial class Withdrawal
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
            this.processingWithdrawalLabel = new System.Windows.Forms.Label();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.processWithdrawal = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.invalidAmt = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invalidPin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processingWithdrawalLabel
            // 
            this.processingWithdrawalLabel.AutoSize = true;
            this.processingWithdrawalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processingWithdrawalLabel.Location = new System.Drawing.Point(424, 386);
            this.processingWithdrawalLabel.Name = "processingWithdrawalLabel";
            this.processingWithdrawalLabel.Size = new System.Drawing.Size(43, 17);
            this.processingWithdrawalLabel.TabIndex = 15;
            this.processingWithdrawalLabel.Text = "label2";
            this.processingWithdrawalLabel.Visible = false;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.withdrawBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.withdrawBtn.ForeColor = System.Drawing.Color.White;
            this.withdrawBtn.Location = new System.Drawing.Point(395, 332);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(98, 34);
            this.withdrawBtn.TabIndex = 14;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // processWithdrawal
            // 
            this.processWithdrawal.Location = new System.Drawing.Point(305, 369);
            this.processWithdrawal.Name = "processWithdrawal";
            this.processWithdrawal.Size = new System.Drawing.Size(280, 11);
            this.processWithdrawal.TabIndex = 13;
            this.processWithdrawal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(298, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter withdrawal amount:";
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Location = new System.Drawing.Point(303, 212);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(280, 26);
            this.amountBox.TabIndex = 11;
            // 
            // invalidAmt
            // 
            this.invalidAmt.AutoSize = true;
            this.invalidAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAmt.ForeColor = System.Drawing.Color.Red;
            this.invalidAmt.Location = new System.Drawing.Point(300, 241);
            this.invalidAmt.Name = "invalidAmt";
            this.invalidAmt.Size = new System.Drawing.Size(43, 17);
            this.invalidAmt.TabIndex = 16;
            this.invalidAmt.Text = "label2";
            this.invalidAmt.Visible = false;
            // 
            // pin
            // 
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin.Location = new System.Drawing.Point(305, 287);
            this.pin.Name = "pin";
            this.pin.PasswordChar = '*';
            this.pin.Size = new System.Drawing.Size(280, 26);
            this.pin.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(298, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter your pin";
            // 
            // invalidPin
            // 
            this.invalidPin.AutoSize = true;
            this.invalidPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPin.ForeColor = System.Drawing.Color.Red;
            this.invalidPin.Location = new System.Drawing.Point(302, 316);
            this.invalidPin.Name = "invalidPin";
            this.invalidPin.Size = new System.Drawing.Size(43, 17);
            this.invalidPin.TabIndex = 19;
            this.invalidPin.Text = "label2";
            this.invalidPin.Visible = false;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.invalidPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.invalidAmt);
            this.Controls.Add(this.processingWithdrawalLabel);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.processWithdrawal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processingWithdrawalLabel;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.ProgressBar processWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label invalidAmt;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label invalidPin;
    }
}