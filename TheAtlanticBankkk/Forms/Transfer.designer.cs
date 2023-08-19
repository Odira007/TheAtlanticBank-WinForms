
namespace TheAtlanticBank_Winforms.Forms
{
    partial class Transfer
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
            this.processingTransferLabel = new System.Windows.Forms.Label();
            this.transferBtn = new System.Windows.Forms.Button();
            this.processTransfer = new System.Windows.Forms.ProgressBar();
            this.beneficiary = new System.Windows.Forms.Label();
            this.beneficiaryAccountNumber = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invalidPin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TextBox();
            this.invalidAmt = new System.Windows.Forms.Label();
            this.invalidBeneficiary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processingTransferLabel
            // 
            this.processingTransferLabel.AutoSize = true;
            this.processingTransferLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processingTransferLabel.Location = new System.Drawing.Point(440, 403);
            this.processingTransferLabel.Name = "processingTransferLabel";
            this.processingTransferLabel.Size = new System.Drawing.Size(43, 17);
            this.processingTransferLabel.TabIndex = 10;
            this.processingTransferLabel.Text = "label2";
            this.processingTransferLabel.Visible = false;
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.transferBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.transferBtn.ForeColor = System.Drawing.Color.White;
            this.transferBtn.Location = new System.Drawing.Point(411, 346);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(98, 34);
            this.transferBtn.TabIndex = 9;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // processTransfer
            // 
            this.processTransfer.Location = new System.Drawing.Point(321, 388);
            this.processTransfer.Name = "processTransfer";
            this.processTransfer.Size = new System.Drawing.Size(280, 11);
            this.processTransfer.TabIndex = 8;
            this.processTransfer.Visible = false;
            // 
            // beneficiary
            // 
            this.beneficiary.AutoSize = true;
            this.beneficiary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.beneficiary.Location = new System.Drawing.Point(316, 134);
            this.beneficiary.Name = "beneficiary";
            this.beneficiary.Size = new System.Drawing.Size(262, 21);
            this.beneficiary.TabIndex = 7;
            this.beneficiary.Text = "Enter beneficiary account number:";
            // 
            // beneficiaryAccountNumber
            // 
            this.beneficiaryAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beneficiaryAccountNumber.Location = new System.Drawing.Point(321, 156);
            this.beneficiaryAccountNumber.Name = "beneficiaryAccountNumber";
            this.beneficiaryAccountNumber.Size = new System.Drawing.Size(280, 26);
            this.beneficiaryAccountNumber.TabIndex = 6;
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Location = new System.Drawing.Point(321, 226);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(280, 26);
            this.amountBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(316, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter transfer amount:";
            // 
            // invalidPin
            // 
            this.invalidPin.AutoSize = true;
            this.invalidPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPin.ForeColor = System.Drawing.Color.Red;
            this.invalidPin.Location = new System.Drawing.Point(321, 322);
            this.invalidPin.Name = "invalidPin";
            this.invalidPin.Size = new System.Drawing.Size(43, 17);
            this.invalidPin.TabIndex = 22;
            this.invalidPin.Text = "label2";
            this.invalidPin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(317, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter your pin";
            // 
            // pin
            // 
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin.Location = new System.Drawing.Point(324, 296);
            this.pin.Name = "pin";
            this.pin.PasswordChar = '*';
            this.pin.Size = new System.Drawing.Size(280, 26);
            this.pin.TabIndex = 20;
            // 
            // invalidAmt
            // 
            this.invalidAmt.AutoSize = true;
            this.invalidAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAmt.ForeColor = System.Drawing.Color.Red;
            this.invalidAmt.Location = new System.Drawing.Point(318, 253);
            this.invalidAmt.Name = "invalidAmt";
            this.invalidAmt.Size = new System.Drawing.Size(43, 17);
            this.invalidAmt.TabIndex = 23;
            this.invalidAmt.Text = "label2";
            this.invalidAmt.Visible = false;
            // 
            // invalidBeneficiary
            // 
            this.invalidBeneficiary.AutoSize = true;
            this.invalidBeneficiary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidBeneficiary.ForeColor = System.Drawing.Color.Red;
            this.invalidBeneficiary.Location = new System.Drawing.Point(317, 183);
            this.invalidBeneficiary.Name = "invalidBeneficiary";
            this.invalidBeneficiary.Size = new System.Drawing.Size(43, 17);
            this.invalidBeneficiary.TabIndex = 24;
            this.invalidBeneficiary.Text = "label2";
            this.invalidBeneficiary.Visible = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.invalidBeneficiary);
            this.Controls.Add(this.invalidAmt);
            this.Controls.Add(this.invalidPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.processingTransferLabel);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.processTransfer);
            this.Controls.Add(this.beneficiary);
            this.Controls.Add(this.beneficiaryAccountNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processingTransferLabel;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.ProgressBar processTransfer;
        private System.Windows.Forms.Label beneficiary;
        private System.Windows.Forms.TextBox beneficiaryAccountNumber;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label invalidPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label invalidAmt;
        private System.Windows.Forms.Label invalidBeneficiary;
    }
}