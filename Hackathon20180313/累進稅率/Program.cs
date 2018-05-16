using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累進稅率
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的年收入：");
            decimal money =decimal.Parse(Console.ReadLine());
            decimal paymoney = 0;
            decimal A = 0, B = 0, C = 0, D = 0,E=0;
            decimal[] tax = { 540000, 1210000, 2420000, 4530000, 10310000 };
            decimal[] pa = { 0.05m, 0.12m, 0.2m, 0.3m, 0.4m, 0.5m };

            A = tax[0] * pa[0];
            B = (tax[1] - tax[0]) * pa[1];
            C = (tax[2] - tax[1]) * pa[2];
            D = (tax[3] - tax[2]) * pa[3];
            E = (tax[4] - tax[3]) * pa[4];
            if (money > tax[5])
            {
                paymoney = A + B + C + D + E + (money - tax[5]) * pa[5];
            }
            else if (tax[5] > money && money > tax[4])
            {
                paymoney = A + B + C + D + E + (money - tax[4]) * pa[4];
            }
            else if (tax[4] > money && money > tax[3])
            {
                paymoney = A + B + C + D + (money - tax[3]) * pa[3];
            }
            else if (tax[3] > money && money > tax[2])
            {
                paymoney = A + B + C + (money - tax[2]) * pa[2];
            }
            else if (tax[2] > money && money > tax[1])
            {
                paymoney = (money - tax[1]) * pa[1] + A + B;
            }
            else if (tax[1] > money && money > tax[0])
            {
                paymoney = (money - tax[0]) * pa[0] + A;
            }
            else if (money < tax[0])
            {
                paymoney = money * pa[0];
            }
        }
    }
}
