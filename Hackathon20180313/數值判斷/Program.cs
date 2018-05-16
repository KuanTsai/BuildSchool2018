using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數值判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"不是3或5的倍數：");
            for (int i=0;i<100;i++)
            {
                if(i % 5 != 0 || i % 3 != 0)
                {
                        Console.Write($"{i}  ");
                }
            }
            Console.ReadLine();
        }
    }
}
