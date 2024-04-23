using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        public BankAccount() { }
        public string NumberAccount { get; set; }
        public decimal Rate { get; set; }
        public Money Balance { get; set; }
        
    }
}
