using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WillBank.Model;
using static Shared.Utilities;

namespace WillBank.Core
{
    public class TransactionRepository : ITransactionRepository
    {
        private UserProfile user = new UserProfile();
        private Account account = new Account();
        private AccountRepository accountRepository = new AccountRepository();
        private readonly string transactionsPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\transactions_data.json";
        private readonly string accountPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\accounts_data.json";

        public bool MakeDeposit(Transaction transaction)
        {
            try
            {
                FileAccessRetrieveTransaction();
                FileAccessRetrieveAccount();
                var customerAccount = user.accountList.Find(account => account.Id == transaction.AccountId);
                transaction.Balance = transaction.Amount + customerAccount.Balance;
                account.transactionList.Add(transaction);
                customerAccount.Balance += transaction.Amount;
                FileAccessAddTransactionRecord();
                FileAccessAddAccountRecord();
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
                FileAccessRetrieveTransaction();
                FileAccessRetrieveAccount();

                var customerAccount = user.accountList.Find(account => account.Id == transaction.AccountId);
                if (customerAccount.Type == AccountType.Current && customerAccount.Balance >= transaction.Amount)
                {
                    transaction.Balance = customerAccount.Balance - transaction.Amount;
                    account.transactionList.Add(transaction);
                    customerAccount.Balance -= transaction.Amount;
                    FileAccessAddTransactionRecord();
                    FileAccessAddAccountRecord();
                    return true;
                }
                else if (customerAccount.Type == AccountType.Savings && customerAccount.Balance > 1000)
                {
                    transaction.Balance = customerAccount.Balance - transaction.Amount;
                    account.transactionList.Add(transaction);
                    customerAccount.Balance -= transaction.Amount;
                    FileAccessAddTransactionRecord();
                    FileAccessAddAccountRecord();
                    return true;
                }

                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public IEnumerable<Transaction> GetTransactionsStatementById(string AccountId)
        {
            try
            {
                FileAccessRetrieveTransaction();
                var details = account.transactionList.Where(prop => prop.AccountId == AccountId).ToList();
                return details;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Transfer(Transaction transaction)
        {
            FileAccessRetrieveTransaction();
            FileAccessRetrieveAccount();
            bool check = transaction.SenderAccount == transaction.ReceiverAccount;
            switch (check)
            {
                case true:
                    return false;

                case false:

                    if (accountRepository.CheckAccountExistByAccountId(transaction.AccountId) == true)
                    {
                        var senderAccount = accountRepository.CheckAccountType(transaction.AccountId);
                        if (
                            senderAccount.Type == AccountType.Current &&
                            senderAccount.Balance > transaction.Amount
                            )
                        {
                            transaction.Balance = senderAccount.Balance - transaction.Amount;
                            account.transactionList.Add(transaction);
                            senderAccount.Balance -= transaction.Amount;
                            FileAccessAddTransactionRecord();
                            FileAccessAddAccountRecord();

                            // Assign values
                            var toAccount = user.accountList.Find(account => account.AccountNumber == transaction.ReceiverAccount);
                            Transaction depositRecipient = new Transaction();
                            depositRecipient.Amount = transaction.Amount;
                            depositRecipient.AccountId = toAccount.Id;
                            depositRecipient.UserId = toAccount.UserId;
                            depositRecipient.Balance = toAccount.Balance + transaction.Amount;
                            depositRecipient.Description = $"Transfer - {transaction.Description}";
                            depositRecipient.Type = TransactionType.Credit;
                            depositRecipient.SenderAccount = transaction.SenderAccount;
                            depositRecipient.ReceiverAccount = transaction.ReceiverAccount;
                            account.transactionList.Add(depositRecipient);
                            FileAccessAddTransactionRecord();
                            FileAccessAddAccountRecord();
                            return true;
                        }
                        else if (
                            senderAccount.Type == AccountType.Savings &&
                            senderAccount.Balance > transaction.Amount &&
                            senderAccount.Balance > 1000 &&
                            accountRepository.GetUserIdWithAccountNumber(transaction.ReceiverAccount) != null
                            )
                        {
                            transaction.Balance = senderAccount.Balance - transaction.Amount;
                            account.transactionList.Add(transaction);
                            senderAccount.Balance -= transaction.Amount;
                            FileAccessAddTransactionRecord();
                            FileAccessAddAccountRecord();
                            // Assign values
                            var toAccount = user.accountList.Find(account => account.AccountNumber == transaction.ReceiverAccount);
                            Transaction depositRecipient = new Transaction();
                            depositRecipient.Amount = transaction.Amount;
                            depositRecipient.AccountId = toAccount.Id;
                            depositRecipient.UserId = toAccount.UserId;
                            depositRecipient.Balance = toAccount.Balance + transaction.Amount;
                            depositRecipient.Description = $"Transfer - {transaction.Description}";
                            depositRecipient.Type = TransactionType.Credit;
                            depositRecipient.SenderAccount = transaction.SenderAccount;
                            depositRecipient.ReceiverAccount = transaction.ReceiverAccount;
                            account.transactionList.Add(depositRecipient);
                            FileAccessAddTransactionRecord();
                            FileAccessAddAccountRecord();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
            }
        }

        private void FileAccessRetrieveAccount()
        {
            var openAccountFile = File.ReadAllText(accountPath);
            try
            {
                user.accountList.Clear();
                var accountObj = JsonSerializer.Deserialize<List<Account>>(openAccountFile);

                foreach (var item in accountObj)
                {
                    user.accountList.Add(item);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void FileAccessRetrieveTransaction()
        {
            var openAccountFile = File.ReadAllText(transactionsPath);
            try
            {
                account.transactionList.Clear();
                var transactionObj = JsonSerializer.Deserialize<List<Transaction>>(openAccountFile);
                foreach (var item in transactionObj)
                {
                    account.transactionList.Add(item);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void FileAccessAddTransactionRecord()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, AllowTrailingCommas = true, IgnoreNullValues = true };
            string accountData = JsonSerializer.Serialize(account.transactionList, options);
            File.WriteAllText(transactionsPath, accountData);
        }

        private void FileAccessAddAccountRecord()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, AllowTrailingCommas = true, IgnoreNullValues = true };
            string accountData = JsonSerializer.Serialize(user.accountList, options);
            File.WriteAllText(accountPath, accountData);
        }
    }
}