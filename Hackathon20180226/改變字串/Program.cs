using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 改變字串
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = -1;
            for(int i=-1; i<100;i++)
            {

                result = result + 1;
                string s = result.ToString().Replace("3","A").Replace("5","B").Replace("9","C").Replace("0","D");
                Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }
}
