
using System;
using static Shared.Utilities;

namespace WillBank.Model
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; }
        public Guid AccountId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string SenderAccount { get; set; }
        public string ReceiverAccount { get; set; }
        private DateTimeOffset CreatedAt { get;}
        public DateTimeOffset UpdatedAt { get; set; }
        public TransactionType Type { get; set; }
        public Transaction()
        {

            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            
        }
    }
}