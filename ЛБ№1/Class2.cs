using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    //Тут Класобдж2(Клас другого об'єкту) реалізує інтерфейс Іобдж, у відміності від першого класу тут можна написати будь який атрибут
    internal class ClassObj2 : Iobj
    {
        public string Name { get; set; } //Назва об'єкту
        public string Color { get; set; } //Колір об'єкту
        
        public string Attr {  get; set; } //Атрибут об'єкту

        // Метод для надання імені об'єкту
        public void Nv()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть ім'я для другого об'єкту");
            this.Name = Console.ReadLine();
            Console.WriteLine("Введіть колір для другого об'єкту");
            this.Color = Console.ReadLine();
        }
        // Метод для встановлення атрибуту об'єкту, можна написати будь що
        public void At()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть атрибут для другого об'єкту");
            this.Attr = Console.ReadLine();
        }
        // Метод для виведення інформації про об'єкт, так само як і в 1 класі виводить кінцеву інформацію
        public void Wi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про другий об'єкт:");
            Console.WriteLine("Ім'я об'єкту:" + Name + "\n" + "Колір об'єкту:" + Color + "\n" + "Атрибут об'єкту:" + Attr );
        }
    }
}
