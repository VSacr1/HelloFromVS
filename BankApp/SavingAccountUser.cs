using System;

namespace BankApp
{
    public class SavingAccountUser : Customer
    {
        public double InterestRate { get; set; }
        public void OutputLogs()
        {
            Console.WriteLine(this.Logs);
        }
    }
}
