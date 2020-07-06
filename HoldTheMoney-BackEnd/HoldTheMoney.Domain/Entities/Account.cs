using System;
using System.Collections.Generic;
using HoldTheMoney.Domain.Enums;

namespace HoldTheMoney.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<Moviment> Moviments { get; set; }
        public AccountType Type { get; set; }

    }
}
