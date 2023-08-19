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
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Helpers;
using TheAtlanticBank.Core.Authentication;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Withdrawal : Form
    {
        private readonly IAccountService _accountService;
        public Withdrawal(IAccountService accountService)
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
                processWithdrawal.Visible = true;
                processWithdrawal.Value++;
                processingWithdrawalLabel.Visible = true;
                processingWithdrawalLabel.Text = "Processing your withdrawal...";
            }
            while (stopwatch.ElapsedMilliseconds < 3000 & processWithdrawal.Value <= processWithdrawal.Maximum - 1);
        }

        private async void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(amountBox.Text, out decimal amount))
            {
                invalidAmt.Visible = true;
                invalidAmt.Text = "Invalid amount";
            }

            if (pin.Text == Authenticate.customer.Pin)
            {
                try
                {
                    var account = Authenticate.selectedAccount;
                    invalidAmt.Visible = false;

                    ProcessTransactionEffect();
                    _accountService.Withdraw(account.AccountId, amount);
                    MessageBox.Show("Withdrawal successful");
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
