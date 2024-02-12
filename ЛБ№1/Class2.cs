using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    internal class ClassObj2 : Iobj
    {
        public string Name { get; set; }
        public string Color { get; set; }
        
        public string Attr {  get; set; }

        public void Nv()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть ім'я для другого об'єкту");
            this.Name = Console.ReadLine();
            Console.WriteLine("Введіть колір для другого об'єкту");
            this.Color = Console.ReadLine();
        }

        public void At()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть атрибут для другого об'єкту");
            this.Attr = Console.ReadLine();
        }

        public void Wi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про другий об'єкт:");
            Console.WriteLine("Ім'я об'єкту:" + Name + "\n" + "Колір об'єкту:" + Color + "\n" + "Атрибут об'єкту:" + Attr );
        }
    }
}
