using System.Collections.Generic;
using WillBank.Model;

namespace WillBank.Core
{
    public interface IAccountRepository
    {
        bool OpenSavingsAccount(Account account);

        bool OpenCurrentAccount(Account account);

        bool CheckAccountExist(string customerId);

        bool CheckAccountExistByAccountId(string accountId);

        Account CheckAccountType(string accountId);

        Account GetUserIdWithAccountNumber(string accountNo);

        IEnumerable<Account> GetAccountById(string userId);
    }
}