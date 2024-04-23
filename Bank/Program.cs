using Bank;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

bool ValidateBankAccount(Customer customer)
{
    var type = typeof(Customer);
    var attributes = type.GetCustomAttributes(false);
    foreach (var attribute in attributes) 
    {
        if (attribute is MyValidationAttribute bankAccountValidate)
            return customer._BankAccount != bankAccountValidate.BankAccount;
    }
    return true;
}

var listTransaction = new List<Transaction>();
var results = new List<ValidationResult>();
var bank = new Banks();

var account = new BankAccount();

account.Rate = 45;
account.NumberAccount = "UA12345678973121556";
account.Balance = new Money();
account.Balance.InSum(100.12m);
listTransaction.Add(new Transaction("Пополнение счета", account.NumberAccount));

var account1 = new BankAccount();
account1.Rate = 45;
account1.NumberAccount = "UA12345568786441556";
account1.Balance = new Money();
await account1.Balance.InSum(1000.26m);
listTransaction.Add(new Transaction("Пополнение счета", account1.NumberAccount));

await bank.AddBankAccount(account);
await bank.AddBankAccount(account1);

var customer = new Customer();
customer.FirstName = "Ваня";
customer.LastName = "Иванов";
await customer.AddBankAccount(account);
await customer.AddBankAccount(account1);

await bank.AddCustomer(customer);

var customer1 = new Customer();
customer1.FirstName = "Николай";
customer1.LastName = "Иванов";

await bank.AddCustomer(customer1);

var val = ValidateBankAccount(customer);
var val1 = ValidateBankAccount(customer1);

if (!val)
{
    Console.WriteLine("Рахунків немає у клієнта");
}
else
{
    await customer.OutBalans("UA12345678973121556");
    await customer.OutBalans("UA12345568786441556");
}
if (!val1)
{
    Console.WriteLine("Рахунків немає у клієнта");
}
else 
{
    await customer1.OutBalans("UA12345568786441556");
}

await account.Balance.OutSum(10.12m);
listTransaction.Add(new Transaction("Снятие ДС со счета", account.NumberAccount));
await customer.OutBalans("UA12345678973121556");

await bank.OutListAccount();
await bank.OutListCustomer();

