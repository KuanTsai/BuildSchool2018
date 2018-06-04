using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 101; x < 200; x++)
            {
                
                for (int i = 2; i < x; i++)
                {
                    if(x % i== 0)
                    {
                        break;
                    }
                    if(i + 1 == x)
                    {
                        Console.WriteLine(x);
                    }
                }

            }
            
            Console.ReadLine();
        }

    }
}
