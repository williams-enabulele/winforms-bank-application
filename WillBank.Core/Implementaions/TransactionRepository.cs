/*using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using WillBank.Model;
using WillBank.Store;

namespace WillBank.Core
{
    public class TransactionRepository : ITransactionRepository
    {
        *//* public string MakeDeposit(Transaction transaction)
         {
             string notification = string.Empty;
             int preCount, postCount;
             try
             {
                 var customerAccount = Customer.Accounts.Find(account => account.Id == transaction.AccountId);
                 transaction.Balance = transaction.Amount + customerAccount.Balance;
                 transaction.Id = count;
                 preCount = DataStore.transactions.Count;
                 DataStore.transactions.Add(transaction);
                 count++;
                 postCount = DataStore.transactions.Count;
                 if (postCount > preCount)
                 {
                     customerAccount.Balance += transaction.Amount;
                     notification = $"Successully deposited NGN{transaction.Amount} Into Account";
                 }
                 else notification = "Something went wrong, try Again";
             }
             catch (ArgumentNullException)
             {
                 notification = "Account Id doesnt exist ";
             }

             return notification;
         }
         public string MakeWithDraw(Transaction transaction)
      }*//*
        public IEnumerable<Transaction> GetTransactionsStatementById(Guid UserId, Guid AccountId, Guid TransactionId)
        {
            if (UserId!=null && AccountId!=null && TransactionId!=null)
            {
                var transactionList = ;
                string notification = string.Empty;
                if (transactionList.Count == 0)
                {
                    notification = "No transactions has been performed";
                }
                else
                {
                    var details = transactionList.Where(prop => prop.AccountId == accountId).ToList();
                    TablePrinter tablePrinter = new TablePrinter("DATE", "DESCRIPTION", "TRANSACTION TYPE", "AMOUNT", "BALANCE");
                    foreach (var transactionItem in details)
                    {
                        tablePrinter.AddRow($"{transactionItem.UpdatedAt}", $"{transactionItem.Description}", $"{transactionItem.Type}", $"{transactionItem.Amount:0.00}", $"{transactionItem.Balance:0.00}");
                    }
                    tablePrinter.Print();
                }
                return notification;
            }
        }

        public bool MakeDeposit(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public bool MakeWithDraw(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public bool Transfer(Guid fromAccountId, Guid toAccountId)
        {
            throw new NotImplementedException();
        }

        // Get Balance from Transactions
        public double getBalance()
        {
            double balance = 0.00;
            Transactions.ForEach(trans => {
                switch (trans.Type)
                {
                    case TransactionType.INTEREST_EARNED:
                    case TransactionType.DEPOSIT:
                        // add to balance
                        balance += trans.Amount;
                        break;
                    case TransactionType.WITHDRAW:
                        balance -= trans.Amount;
                        break;
                }
            });
            return balance;
        }
    }
}*/