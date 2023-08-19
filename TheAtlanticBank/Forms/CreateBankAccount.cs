using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TheAtlanticBank.Core.Interfaces;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank.Helpers;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class CreateBankAccount : Form
    {
        private readonly IAccountService _accountService;
        private readonly IServiceProvider _serviceProvider;

        public CreateBankAccount(IAccountService accountService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _accountService = accountService;
            _serviceProvider = serviceProvider;
        }
        private void savingsAccount_CheckedChanged_1(object sender, EventArgs e)
        {
            if (savingsAccount.Checked == true) currentAccount.Checked = false;
        }

        private void currentAccount_CheckedChanged_1(object sender, EventArgs e)
        {
            if (currentAccount.Checked == true) savingsAccount.Checked = false;
        }

        private async void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (savingsAccount.Checked)
            {
                _accountService.NewAccount('a');
            }
            else
            {
                _accountService.NewAccount('b');
            }

            await FileOperations.SaveToDatabaseAsync();

            var account = _accountService.Get(AccountService.IdCount);
            MessageBox.Show("Account successfully created");

            //Thread.Sleep(1000);
            //var dashboard = _serviceProvider.GetRequiredService<Dashboard>();

            //Hide();
            //dashboard.Show();
        }
    }
}
