using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
   public static class Utilities
    {
        public enum TransactionType
        {
            Credit = 1, 
            Debit=2
        }

        public enum UserType
        {
            Admin = 1, 
            Customer = 2, 
            Employee = 3
        }

        public enum AccountType
        {
            Savings = 1,
            Current = 2
        }
    }
}
