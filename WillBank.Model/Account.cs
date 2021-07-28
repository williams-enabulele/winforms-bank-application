
using System;
using System.Collections.Generic;

namespace WillBank.Model
{
    public class Account
    {
        public Guid Id { get;}
        public Guid UserId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        private DateTime CreatedAt { get;}
        public DateTime UpdatedAt { get; set; }
        public List<Transaction> transactionList = new();

        public Account()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
    
        }
    }
}