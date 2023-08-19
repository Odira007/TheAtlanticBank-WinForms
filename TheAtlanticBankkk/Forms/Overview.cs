using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Helpers;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Common;
using TheAtlanticBank.Core.Authentication;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class Overview : Form
    {
        private DataTable dataTable;
        private DataGridView dataGridView;
        private DataColumn column;
        private DataRow row;
        private DataSet dataSet;

        public Overview()
        {
            InitializeComponent();

            CreateTable();
            CreateDataGridView();

            welcomeLabel.Text += Authenticate.customer.FirstName;
            accountsPanel.Controls.Add(dataGridView);
        }

        public void CreateTable()
        {
            dataTable = new DataTable("Accounts");

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.Caption = "ID";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = true;

            dataTable.Columns.Add(column);

            DataColumn[] primaryKeyColumns = new DataColumn[1];
            primaryKeyColumns[0] = dataTable.Columns["ID"];
            dataTable.PrimaryKey = primaryKeyColumns;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ACCOUNT NAME";
            column.Caption = "Account name";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ACCOUNT NUMBER";
            column.Caption = "Account number";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(AccountType);
            column.ColumnName = "ACCOUNT TYPE";
            column.Caption = "Account type";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "BALANCE";
            column.Caption = "Balance";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            foreach(Account account in FileOperations.GetAccounts())
            {
                row = dataTable.NewRow();

                row["ID"] = account.AccountId;
                row["ACCOUNT NAME"] = account.AccountName;
                row["ACCOUNT NUMBER"] = account.AccountNumber;
                row["ACCOUNT TYPE"] = account.AccountType;
                row["BALANCE"] = account.Balance;

                dataTable.Rows.Add(row);
            }

        }
        private void CreateDataGridView()
        {
            dataGridView = new DataGridView();

            dataGridView.DataSource = dataTable;

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.RowTemplate.Height = 50;
            dataGridView.ForeColor = Color.FromArgb(113, 1, 147);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Lavender;
            dataGridView.BorderStyle = BorderStyle.None;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Account> accounts = FileOperations.GetAccounts();
            int.TryParse(selection.Text, out int num);

            for (int i = 0; i < accounts.Count; i++)
            {  
                if (num > 0 & num <= accounts.Count)
                {
                    var account = accounts[num - 1];
                    Authenticate.selectedAccount = account;
                    accNumber.Text = account.AccountNumber;
                    invalidSelection.Visible = false;
                }
                else
                {
                    accNumber.Text = "";
                    invalidSelection.Visible = true;
                    invalidSelection.Text = "Make sure you selected an account";
                }
                
            }
        }
    }

}
