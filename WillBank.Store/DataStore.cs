using System;
using System.Collections.Generic;
using System.Text;
using WillBank.Model;

namespace WillBank.Store
{
    public class DataStore
    {
        public static List<User> authUser = new();
        public static List<UserProfile> userProfiles = new();
    }
}
