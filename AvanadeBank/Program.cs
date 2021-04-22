using System;
using System.Linq;

namespace AvanadeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Avanade Bank. What would you like to do today?\n1 to open an account.\n2 to check your balance.\n3 to withraw cash.");
            //int userOperation = int.Parse(Console.ReadLine());
            //var userAction = (UserActions)userOperation;
            //switch (userAction)
            //{
            //    case UserActions.OpenAccount:
            //        RegisterNewCustomer();
            //        break;
            //    case UserActions.CheckBalance:
            //        break;
            //    case UserActions.Withdraw:
            //        break;
            //    default:
            //        break;
            //}
            //var customersWithBalanceGreaterThan50Pounds =
            //    CustomerUtility.FindCustomerByBalanceGreaterThanThreshold(500, CustomerUtility.Customers);
            //Console.WriteLine(customersWithBalanceGreaterThan50Pounds.GetDetails());

            //var savingsCustomers = CustomerUtility.FindSavingsCustomers(CustomerUtility.Customers);
            //Console.WriteLine(savingsCustomers.GetDetails()); 
            //var currentCustomers = CustomerUtility.FindCurrentCustomers(CustomerUtility.Customers);
            //Console.WriteLine(currentCustomers.GetDetails());

            //var customersWithBalanceGreaterThan50Pounds = CustomerUtility.FindCustomers(CustomerUtility.Customers, c => c.AccountBalance > 50);
            //Console.WriteLine(customersWithBalanceGreaterThan50Pounds.GetDetails());
            //var savingsCustomers = CustomerUtility.FindCustomers(CustomerUtility.Customers, c => c.AccountType == AccountType.Savings);
            //Console.WriteLine(savingsCustomers.GetDetails());
            //var currentCustomers = CustomerUtility.FindCustomers(CustomerUtility.Customers, c => c.AccountType == AccountType.Current);
            //Console.WriteLine(currentCustomers.GetDetails());

            var customers = CustomerUtility.Customers;
            //var firstCustomer = customers.FirstOrDefault(c => c.Email == "ja@sudo.com");
            //Console.WriteLine(firstCustomer.GetDetails());
            var orderedCustomers = customers.OrderBy(c => c.AccountBalance).ToList();
            Console.WriteLine(orderedCustomers.GetDetails());
        }

        private static void RegisterNewCustomer()
        {
            Console.WriteLine("First Name:");
            string customerFirstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string customerLastName = Console.ReadLine();
            Console.WriteLine("EmailAddress:");
            string customerEmailAddress = Console.ReadLine();
            Console.WriteLine("What account type do you want to open?1 for Savings. 2 for Current.");
            var customerAccountType = int.Parse(Console.ReadLine());
            var customerToAdd = new Customer()
            {
                FirstName = customerFirstName,
                LastName = customerLastName,
                Email = customerEmailAddress,
                AccountType = (AccountType)customerAccountType
            };
            Console.WriteLine($"Thank you {customerToAdd.FullName} for opening an account with us today. Your details have been sent to your email - {customerToAdd.Email}.");
        }
    }
}
