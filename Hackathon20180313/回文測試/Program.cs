using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文測試
{
    public class Program
    {
        static void Main(string[] args)
        {
            Text();
        }

        public static void Text()
        {
            Console.Write("輸入 : ");
            string X = Console.ReadLine();
            char[] i = X.ToCharArray();
            Array.Reverse(i);
            string A = new string(i);
            if (X.Equals(A))
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
            Console.ReadLine();
        }
    }

}
