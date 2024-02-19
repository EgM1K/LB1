using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    // Оголошення класу ClassObjChild, який успадковує від ClassObj, тобто це дочірній клас а перший клас це батьківський
    internal class Cats : Animal
    {
        // Метод для виведення інформації про наслідувальний об'єкт,як і у всіх інших
        public void IAllWriteInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Інформація про наслідувальний об'єкт: ");
            Console.WriteLine("Ім'я тварини: " + Name + "\n" + "Колір тварини: " + Color + "\n" + "Вага тварини: " + Weight + "\n" + "Стать тварини: " + Sex + "\n" + "Вік тварини: " + Age);
        }
    }
}
