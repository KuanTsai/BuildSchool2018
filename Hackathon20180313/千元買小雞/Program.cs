using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 千元買小雞
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0;
            while (((x + y + z) != 100) && ((60.0 * x) + (30.0 * y) + (z)) != 1000.0)
            {
                x++;
                if (((900.0) - (59.0 * x)) % 29.0 == 0)
                {
                    y = ((900.0 - (59.0 * x)) / 29);
                    z = (100 - x - y);
                }

            }
            Console.WriteLine($"x={x},y={y},z={z}");
            Console.ReadLine();
        }
    }
}
