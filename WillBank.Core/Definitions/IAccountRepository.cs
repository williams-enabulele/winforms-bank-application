using System;
using System.Collections.Generic;
using WillBank.Model;

namespace WillBank.Core
{
    public interface IAccountRepository
    {
        bool OpenSavingsAccount(Account account);

        bool OpenCurrentAccount(Account account);

        bool CheckAccountExist(Guid customerId);

        bool CheckAccountExistByAccountId(Guid accountId);

        Account CheckAccountType(Guid accountId);
        Guid GetUserIdWithAccountNumber(string accountNo);
        IEnumerable<Account> GetAccountById(Guid userId);
    }
}