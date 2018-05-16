using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累進稅率2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的年收入：");
            decimal money = decimal.Parse(Console.ReadLine());
            Calculation(money);
            Console.ReadLine();
        }
        private static void Calculation(decimal money)
        {
            Data data = new Data();
            List<Data> list = new List<Data>();
            list.Add(new Data { Level = 540000, Level級差 = 0, Papercent = 0.05m });
            list.Add(new Data { Level = 1210000, Level級差 = 540000, Papercent = 0.12m });
            list.Add(new Data { Level = 2420000, Level級差 = 1210000, Papercent = 0.2m });
            list.Add(new Data { Level = 4530000, Level級差 = 2420000, Papercent = 0.3m });
            list.Add(new Data { Level = 10310000, Level級差 = 4530000, Papercent = 0.4m });
            list.Add(new Data { Level = 10310001, Papercent = 0.5m });
            decimal n = 0, N = 0;
            foreach(var i in list)
            {
                if(money>i.Level)
                {
                    N+=(i.Level-i.Level級差) * i.Papercent;
                }
                else if(money<i.Level)
                {
                    
                    n=(money - i.Level級差) * i.Papercent;
                    break;
                }
            }
            Console.WriteLine(N + n);
        }
    }
}
