using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Helpers;

namespace TheAtlanticBank_Winforms.Forms
{
    public partial class AccountStatement : Form
    {
        private DataTable dataTable;
        private DataGridView dataGridView;
        private DataColumn column;
        private DataRow row;
        private DataSet dataSet;

        public AccountStatement()
        {
            InitializeComponent();

            CreateTable();
            CreateDataGridView();

            //welcomeLabel.Text += Auth.currentCustomer.FirstName;
            transactionsPanel.Controls.Add(dataGridView);
        }

        public void CreateTable()
        {
            dataTable = new DataTable("Transactions");

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "DATE";
            column.Caption = "DATE";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            DataColumn[] primaryKeyColumns = new DataColumn[1];
            primaryKeyColumns[0] = dataTable.Columns["ID"];
            dataTable.PrimaryKey = primaryKeyColumns;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "DESCRIPTION";
            column.Caption = "DESCRIPTION";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "AMOUNT";
            column.Caption = "AMOUNT";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "BALANCE";
            column.Caption = "BALANCE";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            dataTable.Columns.Add(column);

            dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            foreach (Transaction transaction in FileOperations.GetTransactions())
            {
                row = dataTable.NewRow();

                row["DATE"] = transaction.DateOfTransaction;
                row["DESCRIPTION"] = transaction.Description;
                row["AMOUNT"] = transaction.Amount;
                row["BALANCE"] = transaction.Balance;

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
    }
}
