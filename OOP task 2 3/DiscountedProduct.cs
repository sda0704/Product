using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_2_3
{
    internal class DiscountedProduct:Product
    {
        public int Discount { get; private set; }
        public decimal DiscountPrice => Price * (1 -  Discount / 100m);
        public DiscountedProduct(string name, string manufacturer, decimal price, DateTime expirationDate, DateTime productionDate, int discount)
            : base(name, manufacturer, price, expirationDate, productionDate)
        {
            Discount = discount;
            
        }
        public override string ToString()
        {
            return
            "== Информация о товаре == \n" +
              $"Название: {Name}\n" +
              $"Производитель: {Manufacturer}\n" +
              $"Скидка: {Discount}%\n" +
              $"Годен до: {ExpirationDate:dd.MM.yyyy}\n" +
              $"Дата производства: {ProductionDate:dd.MM.yyyy} \n" +
              $"Цена без скидки: {Price:F2} руб.\n" +
              $"Акционная цена: {DiscountPrice} руб. \n";

        }


    }
}
