using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猴子選大王
{
    class Program
    {
        static void Main(string[] args)
        {
            //有100(Monkey)隻猴子,選3(N)淘汰1
            Program N = new Program();
            Console.WriteLine($"有100隻猴子,選3隻淘汰一隻:最終由{N.King(100,3)}號猴子當選大王");
            Console.ReadLine();
        }

        public int King(int Monkey,int N)
        {
            int k = 0;
            for(int i=2;i<=Monkey;i++)
            {
                k = (k + N) % i;
            }
            return ++k;
        }
    }
}
