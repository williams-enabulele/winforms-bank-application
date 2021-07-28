using System;
using System.Collections.Generic;
using static Shared.Utilities;

namespace WillBank.Model
{
    public class Account
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public AccountType Type { get; set; }
        private DateTimeOffset CreatedAt { get; }
        public DateTimeOffset UpdatedAt { get; set; }
        public List<Transaction> transactionList = new();

        public Account()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}