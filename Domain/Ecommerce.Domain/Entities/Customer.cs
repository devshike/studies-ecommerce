using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public IdentityTypeEnum IdentityType { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public Payment Payment { get; set; }

        #region Constructor
        public Customer(string firstName, string lastName, string email, string identityNumber, IdentityTypeEnum identityType, string password, Address address, Payment payment)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdentityNumber = identityNumber;
            IdentityType = identityType;
            Password = password;
            Address = address;
            Payment = payment;
        }
        #endregion
    }
}
