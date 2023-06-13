using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            //2-1
            Console.WriteLine(s);

            //2-2
            int x = int.Parse(s);
            Console.WriteLine(s);

            //2-3
            Console.WriteLine(x + "," +x*x+","+x*x*x);

            //2-4
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x+y+","+(x-y)+","+x*y+","+x/y);

            //2-5
            int z = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((z + a) / 2);

            //2-6
            Console.WriteLine("あなたは現在何歳ですか？");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("あなたが生まれておおよそ"+b*365+"日が経っています。");
        }
    }
}
