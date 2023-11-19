namespace FarmManagementApp.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public string Use { get; set; }
        public string Product { get; set; }
        public int ExpectedYield { get; set; }
    }
}
