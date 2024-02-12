﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Тут також присутні команди для вирішення проблем з українськими буквами
namespace ЛБ_1
{
    //Тут Класобдж(Клас об'єкту) реалізує інтерфейс Іобдж
    internal class ClassObj:Iobj
    {
        public string Name { get; set; } //Ім'я об'єкту чи предмету
        public string Size { get; set; } //Розмір об'єкту чи предмету

        public string Attribute { get; set; } //Атрибут об'єкту чи предмету
        // Метод для введення назви об'єкту, чи предмету
        public void Nv()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (this.Name == null)
            {
                Console.WriteLine("Введіть ім'я");
                this.Name = Console.ReadLine();
            }
            if (this.Size == null)
            {
                Console.WriteLine("Введіть розмір");
                this.Size = Console.ReadLine();
            }
        }
        //Ця команда встановлює метод для надання атрибутів по вибору
        public void At() 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (this.Attribute == null)
            {
                //Тут я зробив щоб користувач міг вибрати один із атрибутів, для різновиду, а то монотомний код нудний
                Console.WriteLine("Введіть Атрибути:  \n Якщо предмет металевий введіть (м) \n Якщо предмет паперовий введіть (п) \n Якщо предмет гумовий введіть (г) \n Якщо предмет скляний введіть (с) \n Якщо предмет з дерева введіть (д)");
                this.Attribute = Console.ReadLine();
                switch(this.Attribute)
                {
                    case "м":
                        this.Attribute = "Предмет металевий";
                        break;
                    case "п":
                        this.Attribute = "Предмет паперовий";
                        break;
                    case "г":
                        this.Attribute = "Предмет гумовий";
                        break;
                    case "с":
                        this.Attribute = "Предмет скляний";
                        break;
                    case "д":
                        this.Attribute = "Предмет з дерева";
                        break;

                }
            }
        }
        //Ця команда встановлює метод по виведеню тексту, тоюто виводить все що користувач написав
        public void Wi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про перший об'єкт:");
            Console.WriteLine("Ім'я об'єкту:" + Name + "\n" + "Розмір об'єкту:" + Size + "\n" + "Матеріал об'єкту:" + Attribute);
        }

    }
}
