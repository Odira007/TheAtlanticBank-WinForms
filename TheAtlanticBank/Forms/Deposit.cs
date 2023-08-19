using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using TheAtlanticBank.Helpers;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Core.Authentication;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Deposit : Form
    {
        private readonly IAccountService _accountService;
        public Deposit(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
            invalidAmt.Visible = false;
        }

        private void ProcessTransactionEffect()
        {
            Stopwatch stopwatch;
            do
            {
                stopwatch = new Stopwatch();
                processDeposit.Visible = true;
                processDeposit.Value++;
                processingDepositLabel.Visible = true;
                processingDepositLabel.Text = "Processing your deposit transaction...";
            }
            while (stopwatch.ElapsedMilliseconds < 3000 & processDeposit.Value <= processDeposit.Maximum - 1);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(amountBox.Text) <= 0)
            {
                invalidAmt.Visible = true;
                invalidAmt.Text = "Please enter a valid amount";
            }
            if (decimal.TryParse(amountBox.Text, out decimal amount))
            {
                try
                {
                    var account = Authenticate.selectedAccount;
                    invalidAmt.Visible = false;

                    _accountService.Deposit(account.AccountId, amount);
                    ProcessTransactionEffect();
                    MessageBox.Show("Deposit successful");
                    await FileOperations.SaveToDatabaseAsync();
                }
                catch (Exception ex)
                {
                    invalidAmt.Visible = true;
                    invalidAmt.Text = ex.Message;

                    var account = Authenticate.selectedAccount;
                }
            }
            else
            {
                invalidAmt.Visible = true;
                invalidAmt.Text = "Invalid amount";
            }

        }
    }
}
