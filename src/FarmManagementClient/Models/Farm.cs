using System.Net;

namespace FarmManagementApp.Models
{
    public class Farm
    {
        public string Name { get; set; }
        public Address FarmAddress { get; set; }
        public decimal TotalArea { get; set; }
        public Owner FarmOwner { get; set; }

        public Farm()
        {
            FarmAddress = new Address();
            FarmOwner = new Owner();
        }
    }
}
