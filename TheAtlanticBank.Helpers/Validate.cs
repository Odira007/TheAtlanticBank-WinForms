using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;

namespace TheAtlanticBank.Helpers
{
    public class Validate
    {
        /// <summary>
        /// Check for valid name entry
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool Name(string name) => new Regex(@"^[A-Z]{1}([a-z]|[A-Z]){1,19}$").IsMatch(name.Trim()) ? true : false;

        /// <summary>
        /// Check for valid password entry
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Password(string password) => new Regex(@"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[!@#$%""^&*()_+\-=\[\]{};':\\|,.<>\/?]).{6,}$").IsMatch(password) ? true : false;

        /// <summary>
        /// Confirm password
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns></returns>
        public static bool ConfirmPassword(string password, string confirmPassword) => password == confirmPassword ? true : false;

        /// <summary>
        /// Validate a user's pin
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool Pin(string pin) => new Regex(@"\d{4}").IsMatch(pin.Trim()) ? true : false;

        /// <summary>
        /// Check for valid email entry
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool Email(string email)
        {
            try
            {
                var emailCheck = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Check if an account exists
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Account FindAccount(string accountNumber, out string message)
        {
            if (!Regex.IsMatch(accountNumber, @"\d{10}"))
            {
                message = "Invalid input";
                return null;
            }
            var account = DataStore.accounts.First(acc => acc.AccountNumber == accountNumber);

            if (account == null)
            {
                message = "Beneficiary does not exist";
            }

            message = string.Empty;
            return account;
        }
    }
}
