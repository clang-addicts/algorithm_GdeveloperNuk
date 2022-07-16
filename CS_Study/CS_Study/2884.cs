using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _2884
    {
        private static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int h = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            if(m < 45)
            {
                m += 15;
                h--;
                if(h < 0)
                {
                    h = 23;
                }
            }
            else
            {
                m -= 45;
            }
            Console.WriteLine("{0} {1}", h, m);
        }
    }
}
