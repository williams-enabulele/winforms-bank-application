using System;
using System.Collections.Generic;
using System.Linq;
using WillBank.Model;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WillsBank.Core
{
    /// <summary>
    /// AccountRepository Class
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        private UserProfile User = new UserProfile();
       

        public string OpenSavingsAccount(Account account)
        {
            if (account != null)
            {
                User.accountList.Add(account);
            }
            return "All fields are required";
        }

        public string OpenCurrentAccount(Account account)
        {
            if (account != null)
            {
                User.accountList.Add(account);
            }
            return "All fields are required";
        }

        public IEnumerable<Account> GetAccountById(Guid userId)
        {
            var accountList = User.accountList;
            try
            {
                var account = accountList.Where(accountItem => accountItem.UserId == userId);
                return account;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CheckAccountExist(Guid userId)
        {
            var accountList = User.accountList;
            try
            {
                var result = accountList.Exists(accountItem => accountItem.UserId == userId);
                if (result == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckAccountExistByAccountId(Guid accountId)
        {
            var accountList = User.accountList;
            try
            {
                var result = accountList.Exists(accountItem => accountItem.Id == accountId);

                if (result == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Account CheckAccountType(Guid accountId)
        {
            var accountList = User.accountList;
            try
            {
                var result = accountList.Find(accountItem => accountItem.Id == accountId);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
           
        }





    }
}