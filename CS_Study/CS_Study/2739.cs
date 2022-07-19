using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _2739
    {
        private static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 9; i++)
            {
                Console.Write("{0} * {1} = {2}", a, i, a * i);
            }
        }
    }
}
