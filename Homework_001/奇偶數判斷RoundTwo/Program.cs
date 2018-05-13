using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶數判斷RoundTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入整數 : ");
            string[] i = Console.ReadLine().Split(',');
            var array = from o in i group o by int.Parse(o) % 2 == 0;
            foreach (var A in array)
            {
                if (A.Key)
                {
                    Console.Write("偶數有 : ");
                }
                else
                {
                    Console.Write("奇數有 : ");
                }
                foreach(var B in A)
                {
                    Console.Write(B + ",");
                }
                Console.ReadLine();
            }
        }
    }
}
