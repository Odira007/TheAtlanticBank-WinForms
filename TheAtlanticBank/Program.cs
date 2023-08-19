using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank_Winforms;
using TheAtlanticBank_Winforms.Forms;

namespace TheAtlanticBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<ICustomerService, CustomerService>();
                    services.AddScoped<ITransactionService, TransactionService>();
                    services.AddScoped<IAccountService, AccountService>();
                    services.AddSingleton<LoginSect>();
                    services.AddTransient<Register>();
                    services.AddTransient<Dashboard>();
                    services.AddTransient<Overview>();
                    services.AddTransient<AccountStatement>();
                    services.AddTransient<Transfer>();
                    services.AddTransient<Withdrawal>();
                    services.AddTransient<Deposit>();
                    services.AddTransient<CreateBankAccount>();
                })
                .Build();

            Application.Run(host.Services.GetRequiredService<LoginSect>());
        }
    }
}
