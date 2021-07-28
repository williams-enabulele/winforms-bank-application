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
    public partial class UserControlWithdraw : UserControl
    {
        private AccountRepository accountRepository = new AccountRepository();
        private Transaction transaction = new Transaction();
        private TransactionRepository transactionRepository = new TransactionRepository();

        public UserControlWithdraw()
        {
            InitializeComponent();
            var accounts = accountRepository.GetAccountById(Program.authUser);
            var filterData = accounts.Select(accountObj => new { accountObj.Id, accountObj.AccountNumber, accountObj.Type }).ToList();
            comboBoxSelectAccount.DataSource = filterData;
            this.comboBoxSelectAccount.DisplayMember = "AccountNumber";
            this.comboBoxSelectAccount.ValueMember = "Id";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtAmount.Text) == true && IsValidText(txtDescription.Text))
            {
                decimal.TryParse(txtAmount.Text, out decimal result);
                transaction.Amount = result;
                transaction.UserId = Program.authUser;
                transaction.Type = TransactionType.Debit;
                transaction.Description = txtDescription.Text;
                transaction.UpdatedAt = DateTimeOffset.Now;
                transaction.AccountId = comboBoxSelectAccount.SelectedValue.ToString();
                bool result2 = transactionRepository.MakeWithDraw(transaction);
                if (result2 == true)
                {
                    MessageBox.Show($"Successfully withdawn {txtAmount.Text} from account {comboBoxSelectAccount.SelectedText}");
                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                }
            }
            else
            {
                MessageBox.Show("Enter Amount in correct format");
            }
        }
    }
}