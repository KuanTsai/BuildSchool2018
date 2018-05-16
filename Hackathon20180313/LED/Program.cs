using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串數字：");
            string input = Console.ReadLine();
            List<string> line1 = new List<string>();
            List<string> line2 = new List<string>();
            List<string> line3 = new List<string>();
            string A0 = " _ ";
            string A1 = "   ";
            string B1 = "| |";
            string B2 = "  |";
            string B3 = " _|";
            string B4 = "|_|";
            string B5 = "|_ ";
            foreach (var i in input)
            {
                switch (i)
                {
                    case '0':
                        line1.Add(A0);
                        line2.Add(B1);
                        line3.Add(B4);
                        break;
                    case '1':
                        line1.Add(A1);
                        line2.Add(B2);
                        line3.Add(B2);
                        break;
                    case '2':
                        line1.Add(A0);
                        line2.Add(B3);
                        line3.Add(B5);
                        break;
                    case '3':
                        line1.Add(A0);
                        line2.Add(B3);
                        line3.Add(B3);
                        break;
                    case '4':
                        line1.Add(A1);
                        line2.Add(B4);
                        line3.Add(B2);
                        break;
                    case '5':
                        line1.Add(A0);
                        line2.Add(B5);
                        line3.Add(B3);
                        break;
                    case '6':
                        line1.Add(A0);
                        line2.Add(B5);
                        line3.Add(B4);
                        break;
                    case '7':
                        line1.Add(A0);
                        line2.Add(B2);
                        line3.Add(B2);
                        break;
                    case '8':
                        line1.Add(A0);
                        line2.Add(B4);
                        line3.Add(B4);
                        break;
                    case '9':
                        line1.Add(A0);
                        line2.Add(B4);
                        line3.Add(B2);
                        break;
                }

            }
            foreach(var i in line1)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            foreach (var i in line2)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            foreach(var i in line3)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
