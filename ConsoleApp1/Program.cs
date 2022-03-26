using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ch = true; int n = 1;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (Math.Abs(n) % 2 == 1) ch = !ch;
            } while (n != 0);
            if (ch) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
