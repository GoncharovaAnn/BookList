using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> BookNames = new List<string>() { "Марсианские хроники", "451 градус по Фаренгейту", "Вино из одуванчиков",  "Властелин колец", "Гордость и предубеждение", "Маленькие женщины", "Убить пересмешника" };
            Console.WriteLine("Список книг:\n");
            foreach (string str in BookNames) 
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Вы хотите добавить/удалить книгу или осуществить поиск по названию?");
            Console.WriteLine("Нажмите \n A для \"Добавить\"\n D для \"Удалить\"\n S для \"Поиск\"(Выводит номер книги в списке)\n");
            string key = Console.ReadLine();
            key = key.ToUpper();
            switch (key)
            {
                case "A":
                {
                    Console.WriteLine("Введите название книги, которую хотите добавить: ");
                    BookNames.Add(Console.ReadLine());
                    Console.WriteLine("Список книг:");
                    foreach (string str in BookNames)
                    {
                        Console.WriteLine(str);
                    }
                    break;
                }
                case "D":
                {
                    Console.WriteLine("Введите название книги, которую хотите удалить: ");
                    bool isDelete = BookNames.Remove(Console.ReadLine());
                    Console.WriteLine("Список книг:");
                    foreach (string str in BookNames)
                    {
                        Console.WriteLine(str);
                    }
                    break;
                }
                case "S":
                {
                    Console.WriteLine("Введите название книги для поиска: ");
                    var index = BookNames.BinarySearch(Console.ReadLine());
                    Console.WriteLine($"Книга находится под номером {index + 1}");
                    Console.WriteLine("Список книг:");
                    foreach (string str in BookNames)
                    {
                        Console.WriteLine(str);
                    }
                    break;
                }
            }
        }
    }
}
