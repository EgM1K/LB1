using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Інформація до кожної команди читається зверху вниз, тобто коментар зверху команди
namespace ЛБ_1
{
    // Оголошення інтерфейсу Iobj
    internal interface IItemOfZooShop
    {
        // Метод для встановлення назви чи імені об'єкта (Name Value)
        public void ReadValues();
        // Метод для встановлення атрибутів (Attributes)
        public void AttributeBasic();
        // Метод для виведення інформації (Write Info)
        public void AllWriteInfo();
    }
}
