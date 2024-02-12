using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    internal class ClassObjChild : ClassObj
    {
        public string AdditionalAttribute { get; set; }

        public void AdditionalMethod()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть додатковий атрибут для наслідувального об'єкту");
            this.AdditionalAttribute = Console.ReadLine();
            Console.WriteLine("Цей метод виконує додаткову функцію для наслідувального об'єкту ");
        }

        public void Wi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про наслідувальний об'єкт:");
            Console.WriteLine("Ім'я об'єкту:" + Name + "\n" + "Розмір об'єкту:" + Size + "\n" + "Матеріал об'єкту:" + Attribute + "\n" + "Додатковий атрибут:" + AdditionalAttribute);
        }
    }
}
