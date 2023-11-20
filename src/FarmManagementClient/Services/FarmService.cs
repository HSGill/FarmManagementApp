using FarmManagementApp.Models;

namespace FarmManagementApp.Services { 
    public interface IFarmService
    {
        Farm GetFarmDetails();
        void UpdateFarmDetails(Farm farm);
    }

    public class FarmService : IFarmService
    {
        private Farm _farm;

        public FarmService()
        {
            // Initialize with sample data or load from storage
            _farm = new Farm
            {
                Name = "Farm 1",
                TotalArea = 100,
                FarmAddress = new Address
                {
                    Country = "Country",
                    State = "State",
                    AddressLine = "123 Farm Street",
                    ZIP = "12345"
                },
                FarmOwner = new Owner
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "john@example.com",
                    PhoneNumber = "123-456-7890"
                }
            };
        }

        public Farm GetFarmDetails()
        {
            return _farm;
        }

        public void UpdateFarmDetails(Farm farm)
        {
            // implement udpate logic here
            _farm = farm;
        }
    }
}
