using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶數判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入整數 : ");
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0)
            {
                Console.WriteLine("判斷 "+ value + " 為偶數。");
            }
            else
            {
                Console.WriteLine("判斷 "+ value + " 為奇數。");
            }
            Console.ReadLine();
        }
    }
}
