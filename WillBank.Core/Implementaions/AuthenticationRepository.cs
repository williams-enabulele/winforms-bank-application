using Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WillBank.Model;

namespace WillBank.Core
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public Guid customerId;
        private readonly Cryptography cryptography = new Cryptography();

        /// <summary>
        /// Allows access to user on confirmation of registration details
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string email, string password)
        {
            string userPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\users_data.json";
            try
            {
                var openUserFile = File.ReadAllText(userPath);
                var userObj = JsonSerializer.Deserialize<List<User>>(openUserFile);

                if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
                {
                    var customerObj = userObj.Find(customer => customer.Email == email);

                    if (cryptography.AreEqual(password, customerObj.Hash, customerObj.Salt))
                    {
                        customerId = customerObj.Id;
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}