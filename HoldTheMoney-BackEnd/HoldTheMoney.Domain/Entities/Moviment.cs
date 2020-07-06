using System;
using HoldTheMoney.Domain.Enums;

namespace HoldTheMoney.Domain.Entities
{
    public class Moviment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime? Date { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public MovimentType Type { get; set; }
        public MovimentStatus Status { get; set; }
        public int MyProperty { get; set; }

    }
}
