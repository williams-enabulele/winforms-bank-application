using Shared;
using System;
using WillBank.Model;
using WillBank.Store;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WillBank.Core
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public Guid customerId;
        private readonly Cryptography cryptography = new Cryptography();
        public UserProfile user = new UserProfile();
        /// <summary>
        /// Allows access to user on confirmation of registration details
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<bool> LoginAsync(string email, string password)
        {
            string userPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\users_data.txt";
            try
            {

                using FileStream openStream = File.OpenRead(userPath);
                var result = await JsonSerializer.DeserializeAsync<User>(openStream);
                DataStore.authUser.Add(result);
                if (email != null && password != null)
                {
                    var customerObj = DataStore.authUser.Find(customer => customer.Email == email);

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