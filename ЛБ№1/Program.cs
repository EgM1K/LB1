using System.Xml.Linq;
using ЛБ_1;

namespace LB
{
    internal class Program
    {
        //Після того як ми ввкли данні до об'єкту консоль стирається, але запам'ятовує атрибути об'єкту, і потім після того як все ввели консоль вивиодить всі данні
        static void Main(string[] args)
        {
            // Встановлюємо кодування для вводу та виводу, щоб був вивід українських букв і вони відображалися, і щоб при написані українських букв вони відображалися
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //Ця команда активує перший клас (батьківський)
            Console.Write("Напишіть назву першого предмету: ");
            var obj1 = new NotMatterialPredmdet();
            obj1.ReadValues();
            obj1.AttributeBasic();
            obj1.AllWriteInfo();
            Console.Clear();
            //Ця команда активує другий клас
            Console.Write("Напишіть ім'я кота: ");
            var obj2 = new Cats();
            obj2.ReadValues();
            obj2.AttributeBasic();
            obj2.IAllWriteInfo();
            Console.Clear();
            //Ця команда активує третій клас (дочірній)
            Console.Write("Напишіть ім'я собаки: ");
            var obj3 = new Dogs();
            obj3.ReadValues();
            obj3.AttributeBasic();
            obj3.IAllWriteInfo();
            Console.Clear();
            //Ця команда виводить всі об'єкти після заверщення вводу всіх даних
            Console.WriteLine("Інформація про всі об'єкти: \n");
            obj1.AllWriteInfo();
            Console.WriteLine("\n------------------------\n");
            obj2.IAllWriteInfo();
            Console.WriteLine("\n------------------------\n");
            obj3.IAllWriteInfo();
        }
    }
}
