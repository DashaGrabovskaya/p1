using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int Number;
        private string Date;
        private decimal Symma;


        public Class1(int Number, string Date, decimal Symma)
        {
            this.Number = Number;
            this.Date = Date;
            this.Symma = Symma;
        }
        public Class1()
        {
            Number = 1;
            Date = null;
            Symma = 0;
        }
        public int number
        {
            get
            {
                return Number;
            }
            set
            {
                this.Number = number;
            }
        }
        public string date
        {
            get
            {
                return Date;
            }
            set
            {
                this.Date = date;
            }
        }
        public decimal symma
        {
            get
            {
                return Symma;
            }
            set
            {
                this.Symma = symma;
            }
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