using System;
using System.Collections.Generic;
using WillBank.Model;

namespace WillBank.Core
{
    public interface ITransactionRepository
    {
        bool MakeDeposit(Transaction transaction);

        bool MakeWithDraw(Transaction transaction);

        bool Transfer(Transaction transaction);
       
        IEnumerable<Transaction> GetTransactionsStatementById(Guid AccountId);
    }
}