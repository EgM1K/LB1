using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Тут також присутні команди для вирішення проблем з українськими буквами
namespace ЛБ_1
{
    //Тут Класобдж(Клас об'єкту) реалізує інтерфейс Іобдж
    internal class NotMatterialPredmdet : IItemOfZooShop
    {
        public string Name { get; set; } //Ім'я об'єкту чи предмету(не живого)
        public string Size { get; set; } //Розмір об'єкту чи предмету(не живого)

        public string Matterial { get; set; } //Атрибут об'єкту чи предмету(не живого)
        // Метод для введення назви об'єкту, чи предмету
        public void ReadValues()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            if (this.Name == null)
            {
                this.Name = Console.ReadLine();
            }
            if (this.Size == null)
            {
                Console.Write("Введіть розмір: ");
                this.Size = Console.ReadLine();
            }
        }
        //Ця команда встановлює метод для надання атрибутів по вибору
        public void AttributeBasic() 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (this.Matterial == null)
            {
                //Тут я зробив щоб користувач міг вибрати один із атрибутів, для різновиду, а то монотомний код нудний
                Console.WriteLine("Введіть Матеріал:  \n Якщо предмет металевий введіть (м) \n Якщо предмет паперовий введіть (п) \n Якщо предмет гумовий введіть (г) \n Якщо предмет скляний введіть (с) \n Якщо предмет з дерева введіть (д)");
                this.Matterial = Console.ReadLine();
                switch(this.Matterial)
                {
                    case "м":
                        this.Matterial = "Предмет металевий";
                        break;
                    case "п":
                        this.Matterial = "Предмет паперовий";
                        break;
            
                    
                    case "г":
                        this.Matterial = "Предмет гумовий";
                        break;
                    case "с":
                        this.Matterial = "Предмет скляний";
                        break;
                    case "д":
                        this.Matterial = "Предмет з дерева";
                        break;

                }
            }
        }
        //Ця команда встановлює метод по виведеню тексту, тоюто виводить все що користувач написав
        public void AllWriteInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Інформація про перший об'єкт:");
            Console.WriteLine("Назва предмету:" + Name + "\n" + "Розмір предмету:" + Size + "\n" + "Матеріал предмету:" + Matterial);
        }

    }
}
