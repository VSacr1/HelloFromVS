using System;

namespace BankApp
{
    public class Customer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        protected string Logs { get; set; }

        public void Register(string name, string emailAddress, string address)
        {
            Name = name;
            EmailAddress = emailAddress;
            Address = address;
            IsActive = true;
            Logs = $"{Name} registered on {DateTime.Now}\n";

            //Console.WriteLine(Logs);
        }
    }
}
