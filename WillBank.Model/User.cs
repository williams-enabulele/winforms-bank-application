using System;
using static Shared.Utilities;

namespace WillBank.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public UserType userType { get; set; }
        public string Salt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}