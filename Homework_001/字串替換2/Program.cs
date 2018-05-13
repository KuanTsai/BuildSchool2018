using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串替換2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入阿拉伯數字 : ");
            string i = Console.ReadLine();
            i = i.Replace("1", "一").Replace("2", "二").Replace("3", "三").Replace("4", "四").Replace("5", "五")
                .Replace("6", "六").Replace("7", "七").Replace("8", "八").Replace("9", "九").Replace("0", "零");
            Console.Write(i);
            Console.ReadLine();
        }
    }
}
