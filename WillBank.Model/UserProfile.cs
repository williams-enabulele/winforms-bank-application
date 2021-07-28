using System.Collections.Generic;

namespace WillBank.Model
{
    public class UserProfile : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Account> accountList = new();

        
    }
}