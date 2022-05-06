using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    internal class Program
    {
        static void Sqr(ref int x)
        {
            x = x * x;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Sqr(ref a);

            Console.WriteLine(a);
            //ref berfungsi menyimpan format ke dalam methods
        }
    }
}
