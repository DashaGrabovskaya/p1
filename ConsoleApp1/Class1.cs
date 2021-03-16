using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public int Number { get; set; }
        public string Date { get; set; }
        public decimal Symma { get; set; }
        public Class1()
        {
            Number = 1;
            Date = null;
            Symma = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine("Номер: {0} Год: {1} Сумма: {2}", Number, Date, Symma);
        }
        public void SetInfo()
        {
            Console.WriteLine("Введите номер: ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дату: ");
            Date = Console.ReadLine();
            Console.WriteLine("Введите сумму: ");
            Symma = Convert.ToDecimal(Console.ReadLine());
        }
    }
}