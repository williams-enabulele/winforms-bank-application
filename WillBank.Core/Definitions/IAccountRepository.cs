using System;
using System.Collections.Generic;
using System.Text;
using WillBank.Model;


namespace WillsBank.Core
{
    public interface IAccountRepository
    {
        string OpenSavingsAccount(Account account);
        string OpenCurrentAccount(Account account);
        bool CheckAccountExist(Guid customerId);
        bool CheckAccountExistByAccountId(Guid accountId);
        Account CheckAccountType(Guid accountId);
        IEnumerable<Account> GetAccountById(Guid userId);


    }
}
