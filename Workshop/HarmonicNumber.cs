using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class HarmonicNumber
    {
        public static void HarmonicNum()
        {
            double num = 0;
            Console.WriteLine("Enter the Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("1/{0}", +i);
                num = num + (1 / (float)i);

            }
            Console.WriteLine("Sum of series upto{0} terms: {1}", n, num);
        }
    }
}
