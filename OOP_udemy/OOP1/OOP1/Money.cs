using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Money
    {
        //private readonly decimal value;
        public Money(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; }

        public decimal TaxValue
        {
            get
            {
                return Value * 1.08m;
            }
        }
    }
}
