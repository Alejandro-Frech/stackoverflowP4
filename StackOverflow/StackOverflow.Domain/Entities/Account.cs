using System;

namespace StackOverflow.Domain.Entities
{
    public class Account : IEntity
    {
        public Guid Id { get; private set ; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CreationDate { get; set; }
        public int ProfileViews { get; set; }
        public string LasTimeSeen { get; set; }
        public string ConfirmPassword { get; set; }
        public int Reputation { set; get; }
        public string ImageUrl { get; set; }
        public bool VerifyEmail { set; get; }
        public Account()
        {
            Id = Guid.NewGuid();
        }
        
    }
}