using Field = FarmManagementApp.Models.Field;

namespace FarmManagementApp.Services
{
    public class FieldService
    {
        private static List<Field> fields = new List<Field>
        {
            new Field { Id = 1, Name = "Field 1", Area = 10, Use = "Vegetables", Product = "Tomatoes", ExpectedYield = 100 },
            new Field { Id = 2, Name = "Field 2", Area = 15, Use = "Fruits", Product = "Apples", ExpectedYield = 150 },
            new Field { Id = 3, Name = "Field 3", Area = 8, Use = "Grains", Product = "Wheat", ExpectedYield = 80 },
            new Field { Id = 4, Name = "Field 4", Area = 12, Use = "Vegetables", Product = "Carrots", ExpectedYield = 120 },
            new Field { Id = 5, Name = "Field 5", Area = 18, Use = "Fruits", Product = "Oranges", ExpectedYield = 180 },
            new Field { Id = 6, Name = "Field 6", Area = 22, Use = "Grains", Product = "Barley", ExpectedYield = 200 },
            new Field { Id = 7, Name = "Field 7", Area = 14, Use = "Vegetables", Product = "Broccoli", ExpectedYield = 140 },
            new Field { Id = 8, Name = "Field 8", Area = 25, Use = "Fruits", Product = "Grapes", ExpectedYield = 250 },
            new Field { Id = 9, Name = "Field 9", Area = 30, Use = "Grains", Product = "Rice", ExpectedYield = 300 },
            new Field { Id = 10, Name = "Field 10", Area = 20, Use = "Vegetables", Product = "Peppers", ExpectedYield = 200 },
            new Field { Id = 11, Name = "Field 11", Area = 17, Use = "Fruits", Product = "Bananas", ExpectedYield = 170 },
            new Field { Id = 12, Name = "Field 12", Area = 28, Use = "Grains", Product = "Oats", ExpectedYield = 280 }
        };

        public List<Field> GetFields()
        {
            return fields.ToList();
        }

        public void AddField(Field field)
        {
            field.Id = fields.Any() ? fields.Max(f => f.Id) + 1 : 1;
            fields.Add(field);
        }
    }
}


