using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _14681
    {
        private static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                if(y > 0)
                {
                    Console.Write(1);
                }
                else if(y < 0)
                {
                    Console.Write(4);
                }
            }
            else if(x < 0)
            {
                if (y > 0)
                {
                    Console.Write(2);
                }
                else if (y < 0)
                {
                    Console.Write(3);
                }
            }
        }
    }
}
