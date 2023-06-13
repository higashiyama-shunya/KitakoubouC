using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-1
            Console.WriteLine("Hello World!");

            //1-2
            int x = 11;
            Console.WriteLine("x=" + x);

            //1-3
            int a= 13;
            int b= 17;

            Console.WriteLine("a=" + a+",b=" + b);

            //1-4
            int c = 13 + 17;
            Console.WriteLine(c);

            //1-5
            Console.WriteLine(13 * 17);

            //1-7
            int d = 3;
            int e = 7;
            int f;
            f = d;
            d = e;
            e = f;
            Console.WriteLine("d={0},e={1}", d, e);

            //1-8
            int g = 19;
            int h = 21;
            int i = g * h;
            Console.WriteLine(i);

            //1-9
            int j = 9;
            Console.WriteLine(j * 2 + "," + j * 3 + "," + j * 4);

            //1-10
            int k = 8;
            Console.WriteLine(k+","+k*k+","+k*k*k);

            //1-11
            int l = 18;
            int m = 6;
            Console.WriteLine(l / m + "," + l % m);

            //1-12
            int n = 29;
            n++;
            Console.WriteLine(n);
            n--;
            Console.WriteLine(n);
        }
    }
}
