using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Windows.Forms;
using TheAtlanticBank.Core.Authentication;
using TheAtlanticBank_Winforms.Forms;
using TheAtlanticBank.Core.Interfaces;

namespace TheAtlanticBank_Winforms
{
    public partial class LoginSect : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public LoginSect(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            invalid1.Visible = false;

            _serviceProvider = serviceProvider;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Authenticate.Login(email.Text, password.Text))
            {
                invalid1.Visible = false;

                Thread.Sleep(500);
                var dashboard = _serviceProvider.GetRequiredService<Dashboard>();

                Hide();
                dashboard.Show();
            }
            invalid1.Visible = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            var register = _serviceProvider.GetRequiredService<Register>();

            Hide();
            register.Show();
        }
    }
}
