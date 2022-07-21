using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class Class1
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] sum = new int[count];
            for(int i = 0; i < count; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                sum[i] = a + b;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
