using Shared;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using WillBank.Model;
using WillBank.Store;
using WillsBank.Core;
using System.Collections.Generic;
using System.Linq;

namespace WillBank.Core
{
    public class UserRepository : IUserRepository
    {
        private readonly Cryptography cryptography = new Cryptography();




        /// <summary>
        /// Registers New users Into The System
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RegisterCustomer(User customer, UserProfile userProfile, string password)
        {
            // Retrieve Previous Records In File

            if (customer != null && !string.IsNullOrWhiteSpace(password))
            {

                string userPath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\users_data.txt";
                string userProfilePath = @"C:\Users\DELL\Desktop\WillBank\WillBank.Store\DataStore\users_profile_data.txt";

                try
                {
                    var jsonUserData = File.ReadAllText(userPath);
                    var userList = JsonSerializer.Deserialize<List<User>>(jsonUserData);
                   foreach (var item in userList)
                            {

                                if (item.Email == customer.Email)
                                {
                            return false;

                                }
                            }     
                    }

                catch (Exception)
                {

                    // continue;
                }
                // Assign form values to model
                string passwordSalt, passwordHash;
                passwordSalt = cryptography.CreateSalt(20);
                passwordHash = cryptography.GenerateHash(password, passwordSalt);
                customer.Hash = passwordHash;
                customer.Salt = passwordSalt;
                customer.userType = Utilities.UserType.Customer;
                DataStore.authUser.Add(customer);
                Guid lastInsertId = customer.Id;
                userProfile.Id = lastInsertId;
                userProfile.userType = customer.userType;
                RegisterProfile(userProfile);
                // Persist List in File
                try
                {
                   
                       
                    var options = new JsonSerializerOptions { WriteIndented = true, AllowTrailingCommas = true, IgnoreNullValues = true };
                    string userData = JsonSerializer.Serialize(customer, options);
            
                    File.AppendAllText(userPath, userData);
                    string userProfileData = JsonSerializer.Serialize(userProfile, options);
                    File.AppendAllText(userProfilePath, userProfileData);
                    return true;
                }


                catch (Exception)
                {

                    return false;
                }


            }


            return false;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RegisterAdmin(User admin, UserProfile userProfile, string password)
        {
            admin.userType = Utilities.UserType.Customer;
            if (admin != null && !string.IsNullOrWhiteSpace(password))
            {
                string passwordSalt, passwordHash;
                passwordSalt = cryptography.CreateSalt(20);
                passwordHash = cryptography.GenerateHash(password, passwordSalt);
                admin.Hash = passwordHash;
                admin.Salt = passwordSalt;
                DataStore.authUser.Add(admin);

                return true;
            }
            return false;

        }

        public bool RegisterProfile(UserProfile userProfile)
        {
            if (userProfile != null)
            {
                DataStore.userProfiles.Add(userProfile);
                return true;
            }
            return false;

        }

    }
}