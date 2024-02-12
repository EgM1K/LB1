using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Інформація до кожної команди читається зверху вниз, тобто коментар зверху команди
namespace ЛБ_1
{
    // Оголошення інтерфейсу Iobj
    internal interface Iobj
    {
        // Метод для встановлення назви чи імені об'єкта (Name Value)
        public void Nv();
        // Метод для встановлення атрибутів (Attributes)
        public void At();
        // Метод для виведення інформації (Write Info)
        public void Wi();
    }
}
