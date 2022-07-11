using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _1330
    {
        private static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            if(int.Parse(s[0]) > int.Parse(s[1]))
            {
                Console.WriteLine(">");
            }
            else if (int.Parse(s[0]) < int.Parse(s[1]))
            {
                Console.WriteLine("<");
            }
            if (int.Parse(s[0]) == int.Parse(s[1]))
            {
                Console.WriteLine("==");
            }
        }
    }
}
