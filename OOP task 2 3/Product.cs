using System;


namespace OOP_task_2_3
{
    internal class Product
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public decimal Price { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime ProductionDate { get; private set; }

        

        public Product(string name, string manufacturer, decimal price, DateTime expirationDate, DateTime productionDate)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ExpirationDate = expirationDate;
            ProductionDate = productionDate;

        }


        public override string ToString()
        {
            return
               "== Информация о товаре == \n" +
               $"Название: {Name}\n" +
               $"Производитель: {Manufacturer}\n" +
               $"Цена: {Price:F2}\n" +
               $"Годен до: {ExpirationDate:dd.MM.yyyy}\n" +
               $"Дата производства: {ProductionDate:dd.MM.yyyy} \n";
        }





    }
}
