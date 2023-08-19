using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank.Core.Authentication;
using Microsoft.Extensions.DependencyInjection;
using TheAtlanticBank;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Register : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Register(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            foreach (Control control in signUpSection.Controls)
            {
                if (control.ForeColor == Color.Red)
                {
                    control.Visible = false;
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);

            var login = _serviceProvider.GetRequiredService<LoginSect>();

            Hide();
            login.Show();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            int countInvalid = 0;
            List<bool> validations = new List<bool> {
                RegisterCustomer.CheckFirstName(firstName, invalidFirstName),
                RegisterCustomer.CheckLastName(lastName, invalidLastName),
                RegisterCustomer.Email(email, invalidEmail),
                RegisterCustomer.Password(password, invalidPassword),
                RegisterCustomer.confirmPassword(password, confirm, invalidConfirm),
                RegisterCustomer.Pin(pin, invalidPin)
            };

            foreach(bool valid in validations)
            {
                if (valid == false) countInvalid++;
            }

            if (countInvalid == 0)
            {
                var customerService = new CustomerService();
                customerService.NewCustomer(firstName.Text, lastName.Text, email.Text, password.Text, pin.Text);

                var customer = Authenticate.customer;
                Thread.Sleep(500);
                var login = _serviceProvider.GetRequiredService<LoginSect>();

                Hide();
                login.Show();
            }
        }
    }
}
