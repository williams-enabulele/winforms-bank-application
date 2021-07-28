using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WillBank.Core;
using WillBank.Model;

namespace WillBank
{
    public partial class UserControlStatement : UserControl
    {
        private TransactionRepository transactionRepository = new TransactionRepository();
        private AccountRepository accountRepository = new AccountRepository();
        private Account accounts = new Account();

        public UserControlStatement()
        {
            InitializeComponent();
            var accounts = accountRepository.GetAccountById(Program.authUser);
            var filterData = accounts.Select(accountObj => new { accountObj.Id, accountObj.AccountNumber, accountObj.Type }).ToList();
            comboBoxUserAccountNo.DataSource = filterData;
            this.comboBoxUserAccountNo.DisplayMember = "AccountNumber";
            this.comboBoxUserAccountNo.ValueMember = "Id";
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            var accounts = transactionRepository.GetTransactionsStatementById(comboBoxUserAccountNo.SelectedValue.ToString());

            // Create Column Headers
            DataTable dataTable = new DataTable("Accounts");
            DataColumn dataColumn = new DataColumn("SN");
            DataColumn dataColumn2 = new DataColumn("Date", typeof(DateTimeOffset));
            DataColumn dataColumn3 = new DataColumn("Amount");
            DataColumn dataColumn4 = new DataColumn("Type");
            DataColumn dataColumn5 = new DataColumn("Balance", typeof(decimal));
            DataColumn dataColumn6 = new DataColumn("Sender Account");
            DataColumn dataColumn7 = new DataColumn("Receiver Account");
            DataColumn dataColumn8 = new DataColumn("Description");
            // Add Columns
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            dataTable.Columns.Add(dataColumn5);
            dataTable.Columns.Add(dataColumn6);
            dataTable.Columns.Add(dataColumn7);
            dataTable.Columns.Add(dataColumn8);

            // keep count
            int count = 1;
            foreach (var accountData in accounts)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["SN"] = count;
                    dataRow["Date"] = accountData.UpdatedAt;
                    dataRow["Amount"] = accountData.Amount;
                    dataRow["Type"] = accountData.Type;
                    dataRow["Balance"] = accountData.Balance;
                    dataRow["Sender Account"] = accountData.SenderAccount;
                    dataRow["Receiver Account"] = accountData.ReceiverAccount;
                    dataRow["Description"] = accountData.Description;
                    dataTable.Rows.Add(dataRow);
                    count++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Data already added to table");
                }
            }
            dataGridStatementView.DataSource = dataTable;
        }
    }
}