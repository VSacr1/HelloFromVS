using System;
using System.Collections.Generic;
using System.Linq;

namespace AvanadeBank
{

    static class CustomerUtility
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer{FirstName="John", LastName="Appleseed", AccountType=AccountType.Current, Email="ja@seed.com", AccountBalance=5000},
            new Customer{FirstName="John", LastName="Hoine", AccountType=AccountType.Savings, Email="ja@deesi.com", AccountBalance=2565},
            new Customer{FirstName="John", LastName="Jones", AccountType=AccountType.Current, Email="ja@desa.com", AccountBalance=10},
            new Customer{FirstName="Amber", LastName="Nelson", AccountType=AccountType.Current, Email="ja@desa.com", AccountBalance=300},
            new Customer{FirstName="Roger", LastName="Alpha", AccountType=AccountType.Savings, Email="ja@suda.com", AccountBalance=50},
            new Customer{FirstName="Mike", LastName="Ross", AccountType=AccountType.Current, Email="ja@sadi.com", AccountBalance=250000},
            new Customer{FirstName="John", LastName="Sakar", AccountType=AccountType.Savings, Email="ja@sudo.com", AccountBalance=252523}
        };
        //public static List<Customer> FindCustomerByBalanceGreaterThanThreshold(decimal threshold, List<Customer> customers)
        //{
        //    List<Customer> customersFound = new List<Customer>();
        //    foreach (var customer in customers)
        //    {
        //        if (customer.AccountBalance > threshold)
        //            customersFound.Add(customer);
        //    }
        //    return customersFound;
        //}
        //public static List<Customer> FindSavingsCustomers(List<Customer> customers)
        //{
        //    List<Customer> customersFound = new List<Customer>();
        //    foreach (var customer in customers)
        //    {
        //        if (customer.AccountType == AccountType.Savings)
        //            customersFound.Add(customer);
        //    }
        //    return customersFound;
        //}
        //public static List<Customer> FindCurrentCustomers(List<Customer> customers)
        //{
        //    List<Customer> customersFound = new List<Customer>();
        //    foreach (var customer in customers)
        //    {
        //        if (customer.AccountType == AccountType.Current)
        //            customersFound.Add(customer);
        //    }
        //    return customersFound;
        //}

        public static List<Customer> FindCustomers(List<Customer> customers, Func<Customer, bool> func)
        {
            //List<Customer> customersFound = new List<Customer>();
            //foreach (var customer in customers)
            //{
            //    if (func(customer))
            //        customersFound.Add(customer);
            //}
            //return customersFound;
            //var customersFound = customers.Where(func).ToList();
            //return customersFound;
            return customers.Where(func).ToList();
        }
        public static string GetDetails(this List<Customer> customers)
        {
            string returnString = "";
            foreach (var c in customers)
            {
                returnString += $"{c.FullName} with {c.Email} has a balance of {c.AccountBalance:c}. Account type: {c.AccountType}.\n";
            }
            return returnString;
        }
        public static string GetDetails(this Customer c)
        {
            return $"{c.FullName} with {c.Email} has a balance of {c.AccountBalance:c}. Account type: {c.AccountType}.";
        }
    }
}
