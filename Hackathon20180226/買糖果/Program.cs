using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 買糖果
{
    class Program
    {
        static void Main(string[] args)
        {
            int n , x , y;
            y=0;x = 10;n = 0;
            while(x>0)
            {
                x--;
                n++;
                
                if(n==3)
                {
                    n = 0;
                }
                else
                {
                    y++;
                }
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
