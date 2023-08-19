using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using TheAtlanticBank.Core.Authentication;
using TheAtlanticBank;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Dashboard : Form
    {
        private Button currentButton;
        private Form activeForm;
        private int tempIndex;
        private Random rand;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccountService _accountService;
        public Dashboard(IAccountService accountService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            rand = new Random();

            _serviceProvider = serviceProvider;
            _accountService = accountService;
        }
        public Dashboard() { }

        public Color GetThemeColor()
        {
            int index = rand.Next(ThemeColor.colors.Count);

            while (tempIndex == index)
            {
                index = rand.Next(ThemeColor.colors.Count);
            }
            tempIndex = index;
            return ColorTranslator.FromHtml(ThemeColor.colors[index]);
        }


        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = GetThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.FromArgb(49, 20, 50);
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in navBar.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.White;
                    prevBtn.ForeColor = Color.FromArgb(49, 20, 50);
                    prevBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        public void OpenChildForms(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.accountView.Controls.Add(childForm);
            this.accountView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void overview_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<Overview>(), sender);
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<Deposit>(), sender);
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<Withdrawal>(), sender);
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<Transfer>(), sender);
        }

        private void accountStatement_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<AccountStatement>(), sender);
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Authenticate.Logout();
            MessageBox.Show("See you next time");

            var loginSect = _serviceProvider.GetRequiredService<LoginSect>();
            Hide();
            loginSect.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<Overview>(), sender);
        }

        private void CreateBankAccount_Click(object sender, EventArgs e)
        {
            OpenChildForms(_serviceProvider.GetRequiredService<CreateBankAccount>(), sender);
        }
    }
}
