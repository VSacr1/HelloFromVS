using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Avanade Bank Ltd. What would you like to do today?\n" +
                "1 to open an account\n2 to check balance");
            int userAction = int.Parse(Console.ReadLine());
            switch (userAction)
            {
                //register
                case 1:
                    RegisterUser();
                    break;
                //check balance
                case 2:

                    break;
                default:
                    break;
            }
        }

        private static void RegisterUser()
        {
            //Customer newCustomer = new Customer();
            SavingAccountUser newCustomer = new SavingAccountUser();
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your email address: ");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();
            newCustomer.Register(name, emailAddress, address);
            newCustomer.OutputLogs();
        }
    }
}
