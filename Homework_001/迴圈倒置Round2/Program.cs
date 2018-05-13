using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迴圈倒置Round2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入整數 : ");
            int value = int.Parse(Console.ReadLine());
            int result = 0;
            for (int x = value; x > 0; x--)
            {
                for (int y = x; y > 0; y--)
                {
                    result -= x;
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
