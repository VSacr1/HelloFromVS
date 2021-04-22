namespace AvanadeBank
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public AccountType AccountType { get; set; }
        public decimal AccountBalance { get; set; } = 0;

    }
}
