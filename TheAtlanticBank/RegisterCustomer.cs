using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Helpers;

namespace TheAtlanticBank
{
    public class RegisterCustomer
    {
        public static bool CheckFirstName(TextBox firstName, Label check)
        {
            if (!Validate.Name(firstName.Text))
            {
                check.Visible = true;
                check.Text = "Invalid name format";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }

        public static bool CheckLastName(TextBox lastName, Label check)
        {
            if (!Validate.Name(lastName.Text))
            {
                check.Visible = true;
                check.Text = "Invalid name format";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }

        public static bool Email(TextBox email, Label check)
        {
            if (!Validate.Email(email.Text))
            {
                check.Visible = true;
                check.Text = "Invalid email format";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }

        public static bool Password(TextBox password, Label check)
        {
            if (!Validate.Password(password.Text))
            {
                check.Visible = true;
                check.Text = "Enter a strong password eg.\"#^&@4eRTfQ1\"";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }

        public static bool confirmPassword(TextBox password, TextBox confirmPassword, Label check)
        {
            if (!Validate.ConfirmPassword(password.Text, confirmPassword.Text))
            {
                check.Visible = true;
                check.Text = "Passwords do not match!";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }

        public static bool Pin(TextBox pin, Label check)
        {
            if (!Validate.Pin(pin.Text) || pin.Text.Length != 4)
            {
                check.Visible = true;
                check.Text = "Please enter a 4-digit pin";
                return false;
            }
            check.Visible = false;
            check.Text = "";
            return true;
        }
    }
}
