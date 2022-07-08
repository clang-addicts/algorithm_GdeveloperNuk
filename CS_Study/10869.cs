using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _10869
    {
        private static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
        }
    }
}
