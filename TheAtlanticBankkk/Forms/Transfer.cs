using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Helpers;
using static TheAtlanticBank.Helpers.Validate;
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Core.Authentication;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Transfer : Form
    {
        private readonly IAccountService _accountService;
        public Transfer(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
        }

        private void ProcessTransactionEffect()
        {
            Stopwatch stopwatch;
            do
            {
                stopwatch = new Stopwatch();
                processTransfer.Visible = true;
                processTransfer.Value++;
                processingTransferLabel.Visible = true;
                processingTransferLabel.Text = "Processing your withdrawal...";
            }
            while (stopwatch.ElapsedMilliseconds < 3000 & processTransfer.Value <= processTransfer.Maximum - 1);
        }

        private async void transferBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(amountBox.Text, out decimal amount))
            {
                invalidAmt.Visible = true;
                invalidAmt.Text = "Invalid amount";
            }
            var beneficiary = FindAccount(beneficiaryAccountNumber.Text, out string message);

            if (beneficiary == null)
            {
                invalidBeneficiary.Visible = true;
                invalidBeneficiary.Text = "Beneficiary does not exist";
            }
            else
            {
                if (pin.Text == Authenticate.customer.Pin)
                {
                    try
                    {
                        var account = Authenticate.selectedAccount;
                        invalidAmt.Visible = false;

                        ProcessTransactionEffect();
                        _accountService.Transfer(account.AccountId, beneficiary.AccountId, amount);
                        MessageBox.Show("Transfer successful");
                        await FileOperations.SaveToDatabaseAsync();
                    }
                    catch (Exception ex)
                    {
                        invalidPin.Visible = true;
                        invalidPin.Text = ex.Message;

                        var account = Authenticate.selectedAccount;
                    }
                }
                else
                {
                    invalidPin.Visible = true;
                    invalidPin.Text = "Invalid pin";
                }

            }
        }

    }
}
