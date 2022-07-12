using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class _9498
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            switch (a / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
