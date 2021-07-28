using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
   public static class Utilities
    {
        public enum TransactionType
        {
            Credit, Debit
        }

        public enum UserType
        {
            Admin, Customer, Employee
        }
    }
}
