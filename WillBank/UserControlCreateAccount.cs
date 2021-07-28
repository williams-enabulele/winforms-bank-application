using System;
using System.Data;
using System.Windows.Forms;
using WillBank.Core;
using WillBank.Model;

namespace WillBank
{
    public partial class UserControlCreateAccount : UserControl
    {
        private AccountRepository accountRepository = new AccountRepository();

        public UserControlCreateAccount()
        {
            InitializeComponent();

            comboBoxAccountType.DataSource = Enum.GetValues(typeof(Shared.Utilities.AccountType));
        }

        private void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.UserId = Program.authUser;

            try
            {
                bool checkAccountTypeSelected = comboBoxAccountType.SelectedItem.Equals(Shared.Utilities.AccountType.Current);
                account.AccountNumber = accountRepository.GenerateAccountNumber();
                switch (checkAccountTypeSelected)
                {
                    case true:

                        if (Shared.Validations.IsValidNumber(txtInitialDeposit.Text) == true)
                        {
                            decimal.TryParse(txtInitialDeposit.Text, out decimal result);
                            account.Balance = result;
                            bool isSuccess = accountRepository.OpenCurrentAccount(account);
                            if (isSuccess == true)
                            {
                                MessageBox.Show("Successfully created an account");
                            }
                            else
                            {
                                MessageBox.Show("Oops! something went wrong");
                            }
                        }
                        break;

                    case false:
                        bool isValid = Shared.Validations.IsValidNumber(txtInitialDeposit.Text) == true;
                        if (isValid)
                        {
                            decimal.TryParse(txtInitialDeposit.Text, out decimal result);
                            account.Balance = result;
                            bool isSuccess = accountRepository.OpenSavingsAccount(account);
                            if (isSuccess == true)
                            {
                                MessageBox.Show("Successfully created an account");
                                btnGetAccount_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Oops! something went wrong");
                            }
                        }

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select account type");
            }
        }

        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            var accounts = accountRepository.GetAccountById(Program.authUser);
            // Create Column Headers
            DataTable dataTable = new DataTable("Accounts");
            DataColumn dataColumn = new DataColumn("SN");
            DataColumn dataColumn1 = new DataColumn("Date", typeof(DateTimeOffset));
            DataColumn dataColumn2 = new DataColumn("Account");
            DataColumn dataColumn3 = new DataColumn("Type");
            DataColumn dataColumn4 = new DataColumn("Balance", typeof(decimal));
            // Add Columns
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            // Instantiate table row

            // keep count
            int count = 1;
            foreach (var accountData in accounts)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["SN"] = count;
                    dataRow["Date"] = accountData.UpdatedAt;
                    dataRow["Account"] = accountData.AccountNumber;
                    dataRow["Type"] = accountData.Type;
                    dataRow["Balance"] = accountData.Balance;
                    dataTable.Rows.Add(dataRow);
                    count++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Data already added to table");
                }
            }
            dataGridAccountView.DataSource = dataTable;
        }
    }
}