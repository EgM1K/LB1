using System.Xml.Linq;
using ЛБ_1;

namespace LB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //Ця команда активує перший клас(головний)
            Console.WriteLine("Напишіть назву першого предмету:");
            var obj1 = new ClassObj();
            obj1.Nv();
            obj1.At();
            obj1.Wi();
            Console.Clear();

            Console.WriteLine("Напишіть назву другого предмету:");
            var obj2 = new ClassObj2();
            obj2.Nv();
            obj2.At();
            obj2.Wi();
            Console.Clear();

            Console.WriteLine("Напишіть назву третього предмету:");
            var obj3 = new ClassObjChild();
            obj3.Nv();
            obj3.At();
            obj3.AdditionalMethod();
            obj3.Wi();
            Console.Clear();

            Console.WriteLine("Інформація про всі об'єкти:\n");
            obj1.Wi();
            Console.WriteLine("\n------------------------\n");
            obj2.Wi();
            Console.WriteLine("\n------------------------\n");
            obj3.Wi();
        }
    }
}
