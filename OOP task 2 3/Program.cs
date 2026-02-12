using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_2_3
{
    internal class Program
    {
        private const string FormatDate = "dd.MM.yyyy";
        static void Main(string[] args)
        {
            string name = "";
            string manufacturer = "";
            decimal price = 0;
            DateTime expirationDate = DateTime.Now;
            DateTime productionDate = DateTime.Now;
            int discount = 0;
            Product product = null;


            while (true)
            {
                Console.WriteLine("Выберите режим работы: \n1. Ввод данных продукта \n2. Просмотр информации о товаре \n3. Выход из программы");
                int mode = Convert.ToInt32(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("1. Цена без скидки \n2. Цена со скидкой");
                        int productType = Convert.ToInt32(Console.ReadLine());
                        switch (productType)
                        {
                            case 1:
                                {
                                    Console.WriteLine("==Заполнение данных о продукте==");
                                    Console.WriteLine("Имя: ");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Производитель: ");
                                    manufacturer = Console.ReadLine();
                                    Console.WriteLine("Цена: ");

                                    while (!decimal.TryParse(Console.ReadLine(), out price))
                                    {
                                        Console.WriteLine("Ошибка! Введите число!");
                                    }


                                    Console.WriteLine($"Срок годности до (Формат: {FormatDate}): ");
                                    while (true)
                                    {
                                        string input = Console.ReadLine();
                                        if (!DateTime.TryParse(input, out expirationDate))
                                        {
                                            Console.WriteLine($"Неверный формат даты\nФормат: {FormatDate}");
                                            continue;
                                        }

                                        break;
                                    }

                                    Console.WriteLine($"Дата производства (Формат: {FormatDate}): ");
                                    while (true)
                                    {
                                        string input = Console.ReadLine();

                                        if (!DateTime.TryParse(input, out productionDate))
                                        {
                                            Console.WriteLine($"Неверный формат даты\nФормат: {FormatDate}");
                                            continue;
                                        }

                                        break;

                                    }


                                    product = new Product(
                                 name,
                                 manufacturer,
                                 price,
                                 expirationDate,
                                 productionDate);
                                    Console.WriteLine();
                                    continue;
                                }
                            case 2:
                                {
                                    Console.WriteLine("==Заполнение данных о продукте==");
                                    Console.WriteLine("Имя: ");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Производитель: ");
                                    manufacturer = Console.ReadLine();
                                    Console.WriteLine("Цена: ");

                                    while (!decimal.TryParse(Console.ReadLine(), out price))
                                    {
                                        Console.WriteLine("Ошибка! Введите число!");
                                    }

                                    Console.WriteLine("Размер скидки:");

                                    while (true)
                                    {
                                        while (!int.TryParse(Console.ReadLine(), out discount))
                                        {
                                            Console.WriteLine("Ошибка! Введите целое число:");
                                        }

                                        if (discount > 100)
                                        {
                                            Console.WriteLine("Ошибка! Скидка не может быть более 100% \nВведите другое значение:");
                                            continue;

                                        }
                                        break;
                                    }


                                    Console.WriteLine($"Срок годности до (Формат: {FormatDate}): ");
                                    while (true)
                                    {
                                        string input = Console.ReadLine();
                                        if (!DateTime.TryParse(input, out expirationDate))
                                        {
                                            Console.WriteLine($"Неверный формат даты\nФормат: {FormatDate}");
                                            continue;
                                        }

                                        break;

                                    }

                                    Console.WriteLine($"Дата производства (Формат: {FormatDate}): ");
                                    while (true)
                                    {
                                        string input = Console.ReadLine();

                                        if (!DateTime.TryParse(input, out productionDate))
                                        {
                                            Console.WriteLine($"Неверный формат даты\nФормат: {FormatDate}");
                                            continue;
                                        }

                                        break;

                                    }

                                    product = new DiscountedProduct(
                                        name,
                                        manufacturer,
                                        price,
                                        expirationDate,
                                        productionDate,
                                        discount
                                       );
                                    Console.WriteLine();

                                }
                                continue;

                        }
                        break;

                    case 2:
                        if (product != null)
                        {
                            Console.WriteLine(product);
                        }
                        else
                        {
                            Console.WriteLine("Сначала введите данные товара");
                        }
                        continue;
                    case 3:

                        return;
                }
            }
        }                 
        }
    }