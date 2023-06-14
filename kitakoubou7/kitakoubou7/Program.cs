using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("チワワ");
            Dog dog2 = new Dog("ブルドッグ");

            dog.Name = "太郎";
            dog.Age = 19;

            dog2.Name = "コタロー";
            dog2.Age = 15;

            dog.ShowProfile();
            dog2.ShowProfile();

            CoinCase cc = new CoinCase();
            Console.WriteLine("投入するコインの種類と枚数を入力");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}回目", i + 1);
                Console.WriteLine("種類");
                int coin = int.Parse(Console.ReadLine());
                Console.WriteLine("枚数");
                int num = int.Parse(Console.ReadLine());

                cc.AddCoins(coin, num);
            }
            Console.WriteLine("500円の枚数:{0}枚.総額:{1}", cc.GetCount(500), cc.GetAmount(500));
            Console.WriteLine("100円の枚数:{0}枚.総額:{1}", cc.GetCount(100), cc.GetAmount(100));
            Console.WriteLine("50円の枚数:{0}枚.総額:{1}", cc.GetCount(50), cc.GetAmount(50));
            Console.WriteLine("10円の枚数:{0}枚.総額:{1}", cc.GetCount(10), cc.GetAmount(10));
            Console.WriteLine("5円の枚数:{0}枚.総額:{1}", cc.GetCount(5), cc.GetAmount(5));
            Console.WriteLine("1円の枚数:{0}枚.総額:{1}", cc.GetCount(1), cc.GetAmount(1));

            Console.WriteLine("全てのコインの枚数:{0}", cc.GetCount());
            Console.WriteLine("総額:{0}円", cc.GetAmount());
        }
    }
}
