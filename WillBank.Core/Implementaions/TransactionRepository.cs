using System;
using System.Collections.Generic;
using System.Linq;
using WillBank.Model;
using static Shared.Utilities;

namespace WillBank.Core
{
    public class TransactionRepository : ITransactionRepository
    {
        private UserProfile user = new UserProfile();
        private Account account = new Account();
        private IAccountRepository accountRepository;

        public bool MakeDeposit(Transaction transaction)
        {
            try
            {
                var customerAccount = user.accountList.Find(account => account.Id == transaction.AccountId);
                transaction.Balance = transaction.Amount + customerAccount.Balance;
                account.transactionList.Add(transaction);
                customerAccount.Balance += transaction.Amount;
                return true;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public bool MakeWithDraw(Transaction transaction)
        {
            try
            {
                var customerAccount = user.accountList.Find(account => account.Id == transaction.AccountId);
                transaction.Balance = transaction.Amount - customerAccount.Balance;
                account.transactionList.Add(transaction);
                customerAccount.Balance -= transaction.Amount;
                return true;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public IEnumerable<Transaction> GetTransactionsStatementById(Guid AccountId)
        {
            if (account.transactionList.Count == 0)
            {
                return null;
            }
            else
            {
                var details = account.transactionList.Where(prop => prop.AccountId == AccountId).ToList();
                return details;
            }
        }

        public bool Transfer(Transaction transaction)
        {
            bool check = transaction.SenderAccount == transaction.ReceiverAccount;
            switch (check)
            {
                case true:
                    return false;

                case false:
                    if (accountRepository.CheckAccountExistByAccountId(transaction.AccountId) != true)
                    {
                        var senderAccount = accountRepository.CheckAccountType(transaction.AccountId);
                        if (senderAccount.Type == AccountType.Current && senderAccount.Balance > transaction.Amount)
                        {
                            MakeWithDraw(transaction);
                        }
                        else if (senderAccount.Type == AccountType.Savings && senderAccount.Balance > transaction.Amount && senderAccount.Balance > 1000)
                        {
                            MakeWithDraw(transaction);
                        }

                        if (accountRepository.GetUserIdWithAccountNumber(transaction.ReceiverAccount) != Guid.Empty)
                        {
                            // Assign values
                            Transaction depositRecipient = new();
                            depositRecipient.Amount = 1000;
                            depositRecipient.UserId = accountRepository.GetUserIdWithAccountNumber(transaction.ReceiverAccount);
                            depositRecipient.Description = $"Transfer - {transaction.Description}";
                            depositRecipient.Type = TransactionType.Credit;
                            depositRecipient.SenderAccount = "567--";
                            depositRecipient.ReceiverAccount = "567";
                            MakeDeposit(depositRecipient);
                            return true;
                        }
                        else return false;
                    }
                    else
                    {
                        return false;
                    }
            }
        }
    }
}