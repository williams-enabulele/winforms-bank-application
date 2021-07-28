using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WillBank.Core;
using WillBank.Model;
using static Shared.Utilities;
using static Shared.Validations;

namespace WillBank
{
    public partial class UserControlTransfer : UserControl
    {
        private TransactionRepository transactionRepository = new TransactionRepository();
        private AccountRepository accountRepository = new AccountRepository();
        private Transaction transaction = new Transaction();

        public UserControlTransfer()
        {
            InitializeComponent();
            var accounts = accountRepository.GetAccountById(Program.authUser);
            var filterData = accounts.Select(accountObj => new { accountObj.Id, accountObj.AccountNumber, accountObj.Type }).ToList();
            comboBoxSelectAccount.DataSource = filterData;
            this.comboBoxSelectAccount.DisplayMember = "AccountNumber";
            this.comboBoxSelectAccount.ValueMember = "Id";
        }

        private void UserControlTransfer_Load(object sender, EventArgs e)
        {
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtAmount.Text) == true && IsValidNumber(txtAmount.Text) && !string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                decimal.TryParse(txtAmount.Text, out decimal result);
                transaction.Amount = result;
                transaction.UserId = Program.authUser;
                transaction.Type = TransactionType.Debit;
                transaction.ReceiverAccount = comboBoxSelectAccount.SelectedItem.ToString();
                transaction.ReceiverAccount = txtAccountNo.Text;
                transaction.Description = txtDescription.Text;
                transaction.AccountId = comboBoxSelectAccount.SelectedValue.ToString();
                bool isSuccess = transactionRepository.Transfer(transaction);
                if (isSuccess == true)
                {
                    MessageBox.Show($"Successfully transfered {txtAmount.Text} into {transaction.ReceiverAccount}");
                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }
    }
}