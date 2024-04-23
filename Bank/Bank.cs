using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Banks
    {
        public List<BankAccount> _BankAccount;
        public List<Customer> _Customer;
        public Banks() { }

        public async Task OutListAccount () 
        {
            foreach (var account in _BankAccount)
            {
                Console.WriteLine (account.NumberAccount);
            }
        }
        public async Task OutListCustomer()
        {
            foreach (var item in _Customer)
            {
                Console.WriteLine($"{item.FirstName} - {item.LastName}");
            }
        }
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
            }
        }
        public async Task AddCustomer(Customer customer) 
        {
            try
            {
                _Customer.Add(customer);
            }
            catch (Exception ex)
            {
                _Customer = new List<Customer>();
                _Customer.Add(customer);
            }

        }

    }
}
