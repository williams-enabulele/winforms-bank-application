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
    public partial class UserControlDeposit : UserControl
    {
        private AccountRepository accountRepository = new AccountRepository();
        private Transaction transaction = new Transaction();
        private TransactionRepository transactionRepository = new TransactionRepository();

        public UserControlDeposit()
        {
            InitializeComponent();
            var accounts = accountRepository.GetAccountById(Program.authUser);
            var filterData = accounts.Select(accountObj => new { accountObj.Id, accountObj.AccountNumber, accountObj.Type }).ToList();
            comboBoxSelectAccount.DataSource = filterData;
            this.comboBoxSelectAccount.DisplayMember = "AccountNumber";
            this.comboBoxSelectAccount.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtAmount.Text) == true && IsValidText(txtDescription.Text))
            {
                decimal.TryParse(txtAmount.Text, out decimal result);
                transaction.Amount = result;
                transaction.UserId = Program.authUser;
                transaction.Type = TransactionType.Credit;
                transaction.Description = txtDescription.Text;
                transaction.UpdatedAt = DateTimeOffset.Now;
                transaction.AccountId = comboBoxSelectAccount.SelectedValue.ToString();
                transactionRepository.MakeDeposit(transaction);
                MessageBox.Show($"Successfully deposited {txtAmount.Text} into account ");
            }
            else
            {
                MessageBox.Show("Enter Amount in correct format");
            }
        }
    }
}