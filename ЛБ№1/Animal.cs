using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    //Тут Класобдж2(Клас другого об'єкту) реалізує інтерфейс Іобдж, у відміності від першого класу тут можна написати будь який атрибут
    internal class Animal : IItemOfZooShop
    {
        public string Name { get; set; } //Назва тварини
        public string Color { get; set; } //Колір тварини

        public string Weight {  get; set; } //Вагу тварини

        public string Sex { get; set; }//Стать тварини

        public string Age { get; set; }//Вік тварини
        // Метод для надання імені об'єкту
        public void ReadValues()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            this.Name = Console.ReadLine();
        }
        // Метод для встановлення атрибуту об'єкту, можна написати будь що
        public void AttributeBasic()
        {
            Console.Write("Введіть колір для тварини: ");
            this.Color = Console.ReadLine();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть вагу тварини: ");
            this.Weight = Console.ReadLine();
            Console.Write("Введіть стать тварини: ");
            this.Sex = Console.ReadLine();
            Console.Write("Введіть вік тварини: ");
            this.Age = Console.ReadLine();
        }
        // Метод для виведення інформації про об'єкт, так само як і в 1 класі виводить кінцеву інформацію
        public void AllWriteInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про другий об'єкт: ");
            Console.WriteLine("Ім'я тварини: " + Name + "\n" + "Колір тварини: " + Color + "\n" + "Вага тварини: " + Weight + "\n" + "Стать тварини: " + Sex + "\n" + "Вік тварини: " + Age);
        }
    }
}
