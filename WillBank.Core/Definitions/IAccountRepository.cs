using System;
using System.Collections.Generic;
using System.Text;
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
        IEnumerable<Account> GetAccountById(Guid userId);


    }
}
