using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WillBank.Core;
using WillBank.Model;
using static Shared.Validations;
using static Shared.Utilities;


namespace WillBank
{
    public partial class UserControlDeposit : UserControl
    {
        AccountRepository accountRepository = new AccountRepository();
        Transaction transaction = new Transaction();
        ITransactionRepository transactionRepository;
        public UserControlDeposit()
        {
            InitializeComponent();
            var accounts = accountRepository.GetAccountById(Program.authUser);
            var filterData = accounts.Select(accountObj => new { accountObj.Id, accountObj.AccountNumber , accountObj.Type }).ToList();
            comboBoxSelectAccount.DataSource = filterData;
            this.comboBoxSelectAccount.DisplayMember = "AccountNumber -Type";
            this.comboBoxSelectAccount.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(txtAmount.Text) == true)
            {
                decimal.TryParse(txtAmount.Text, out decimal result);
                transaction.Amount = result;
                transaction.Type = TransactionType.Debit;
                transaction.Description = "Self";
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
