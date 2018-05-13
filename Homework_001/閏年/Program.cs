using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 閏年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年份 : ");
            string i = Console.ReadLine();
            int year = int.Parse(i);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year +" 為閏年");
            }
            else
            {
                Console.WriteLine(year+"不是閏年");
            }
            Console.ReadLine();
        }
    }
}
