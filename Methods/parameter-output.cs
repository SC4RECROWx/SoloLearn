using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    internal class Program
    {
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }

        static void Main(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            //Now Equals 5, b equals 42

            Console.WriteLine(a + "\n" + b);
            //out parameter memberi keluaran output
        }
    }
}
