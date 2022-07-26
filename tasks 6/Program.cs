using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            var count = (new DateTime(DateTime.Now.Year, 12, 31) - DateTime.Now).Days;
            Console.WriteLine("Количество дней до нового года: {0} ", count);
        }
    }
}