using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WillBank.Model;
using static Shared.Utilities;

namespace WillBank.Core
{
    /// <summary>
    /// AccountRepository Class
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        private UserProfile User = new UserProfile();
        private readonly string accountPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\accounts_data.json";

        public bool OpenSavingsAccount(Account account)
        {
            FileAccessRetrieveSave();
            if (account != null)
            {
                account.Type = AccountType.Savings;
                User.accountList.Add(account);
                FileAccessAddRecord();
                return true;
            }
            return false;
        }

        public bool OpenCurrentAccount(Account account)
        {
            FileAccessRetrieveSave();
            if (account != null)
            {
                account.Type = AccountType.Current;
                User.accountList.Add(account);
                FileAccessAddRecord();
                return true;
            }
            return false;
        }

        public IEnumerable<Account> GetAccountById(Guid userId)
        {
            FileAccessRetrieveSave();
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
            FileAccessRetrieveSave();
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
            FileAccessRetrieveSave();
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

        public string GenerateAccountNumber()
        {
            string accountNum = "1089";
            var rand = new Random();
            var randNum = rand.Next(100000, 999999);
            accountNum += randNum.ToString();
            return accountNum;
        }

        public Account CheckAccountType(Guid accountId)
        {
            FileAccessRetrieveSave();
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


        public Guid GetUserIdWithAccountNumber(string accountNo)
        {
            FileAccessRetrieveSave();
            var accountList = User.accountList;
            try
            {
                var result = accountList.Find(accountItem => accountItem.AccountNumber == accountNo);
                return result.UserId;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        private void FileAccessRetrieveSave()
        {
            var openAccountFile = File.ReadAllText(accountPath);
            try
            {
                var accountObj = JsonSerializer.Deserialize<List<Account>>(openAccountFile);

                foreach (var item in accountObj)
                {
                    User.accountList.Add(item);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void FileAccessAddRecord()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, AllowTrailingCommas = true, IgnoreNullValues = true };
            string accountData = JsonSerializer.Serialize(User.accountList, options);
            File.WriteAllText(accountPath, accountData);
        }
    }
}