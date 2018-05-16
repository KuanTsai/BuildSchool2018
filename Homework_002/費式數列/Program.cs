using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 費式數列
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.Write("請輸入數字決定數列的項目:");
            bool X = int.TryParse(Console.ReadLine(), out N);
            int[] list = new int[N];
            list[0] = 0;
            list[1] = 1;
            for (int n = 2; n < N; n++)
            {
                list[n] = list[n - 2] + list[n - 1];
            }
            
            for (int i = 1; i < N; i++)
            {
                Console.Write($" {list[i]}");
            }
            Console.ReadLine();
        }
    }
}
