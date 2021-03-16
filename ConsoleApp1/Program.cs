using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Квитанция");
            Class1 P = new Class1();
            P.SetInfo();
            P.GetInfo();
            Console.ReadKey();
        }
    }
}
