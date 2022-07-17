using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _2525
    {
        private static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int h = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            int c = int.Parse(Console.ReadLine());

            m += c;
            while(m >= 60)
            {
                h++;
                m -= 60;
            }
            if(h >= 24)
            {
                h -= 24;
            }
            Console.WriteLine("{0} {1}", h, m);
        }
    }
}
