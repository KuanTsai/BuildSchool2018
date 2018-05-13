using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迴圈倒置1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入 : ");
            string[] i = Console.ReadLine().Split(',');
            Array.Reverse(i);
            Console.Write("結果：");
            foreach (var A in i)
            {
                Console.Write(A + ",");
            }
            Console.ReadLine();
        }
    }
}
