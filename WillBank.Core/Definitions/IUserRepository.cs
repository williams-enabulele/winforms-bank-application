using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WillBank.Model;

namespace WillsBank.Core
{
    public interface IUserRepository
    {
     bool RegisterCustomer(User customer,UserProfile userProfile, string password);
      bool RegisterAdmin(User admin,UserProfile userProfile, string password);
      bool RegisterProfile(UserProfile userProfile);
    }

}
