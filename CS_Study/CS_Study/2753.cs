using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _2753
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            if((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
