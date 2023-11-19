namespace Ecommerce.Domain.Models
{
    public class AddressViewModel
    {
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string AdditionalInformation { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public AddressViewModel(string street, string number, string additionalInformation, string zipCode, string city, string state, string country)
        {
            Street = street;
            Number = number;
            AdditionalInformation = additionalInformation;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
        }
    }
}
