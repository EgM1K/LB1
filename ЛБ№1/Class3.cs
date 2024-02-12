using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    // Оголошення класу ClassObjChild, який успадковує від ClassObj, тобто це дочірній клас а перший клас це батьківський
    internal class ClassObjChild : ClassObj
    {
        public string AdditionalAttribute { get; set; }
        // Метод для встановлення додаткового атрибуту об'єкту, він дадається до 1 класу разом з наслідувальними методами
        public void AdditionalMethod()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть додатковий атрибут для наслідувального об'єкту");
            this.AdditionalAttribute = Console.ReadLine();
            Console.WriteLine("Цей метод виконує додаткову функцію для наслідувального об'єкту ");
        }
        // Метод для виведення інформації про наслідувальний об'єкт,як і у всіх інших
        public void Wi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про наслідувальний об'єкт:");
            Console.WriteLine("Ім'я об'єкту:" + Name + "\n" + "Розмір об'єкту:" + Size + "\n" + "Матеріал об'єкту:" + Attribute + "\n" + "Додатковий атрибут:" + AdditionalAttribute);
        }
    }
}
