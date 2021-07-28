using System;
using System.Collections.Generic;
using System.Text;
using WillBank.Model;


namespace WillBank.Core
{
    public interface ITransactionRepository
    {

        bool MakeDeposit(Transaction transaction);
        bool MakeWithDraw(Transaction transaction);
        bool Transfer(Guid fromAccountId, Guid toAccountId);
        IEnumerable<Transaction> GetTransactionsStatementById(Guid UserId, Guid AccountId, Guid TransactionId);
    }
}
