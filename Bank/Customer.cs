using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    [MyValidation()]
    internal class Customer
    {

        public List<BankAccount> _BankAccount;

        public Customer() { }

        public string LastName { get; set; }
       
        public string FirstName { get; set; }

        public async Task AddBankAccount(BankAccount bankAccount)
        {
            try
            {
                _BankAccount.Add(bankAccount);
            }
            catch (Exception ex)
            {
                _BankAccount = new List<BankAccount>();
                _BankAccount.Add(bankAccount);
                Console.WriteLine("Рахунок відкрили");
            }
        }

        public async Task OutBalans(string NumberAccount)
        {
            if (_BankAccount == null)
            {
                Console.WriteLine("Рахунків немає у клієнта1");
                return;
            }
            

            var balans = _BankAccount.Where(bal => bal.NumberAccount == NumberAccount);

            if (balans.Count() == 0)
            {
                Console.WriteLine("Рахонок не знайдено");
            }
            else
            {
                foreach (var item in balans)
                {
                    Console.WriteLine($"По рахунку {NumberAccount} - баланс {item.Balance._Total}");
                }
            }
        }

    }
}
