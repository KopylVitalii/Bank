using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class MyValidationAttribute:ValidationAttribute
    {
        public List<BankAccount> BankAccount { get; private set; }
        public MyValidationAttribute() { }

    }
}
