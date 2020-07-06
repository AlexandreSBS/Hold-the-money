using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HoldTheMoney.Domain.ValueObjects;

namespace HoldTheMoney.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Account> Accounts { get; set; }
        public AuthInfo AuthInfo { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
