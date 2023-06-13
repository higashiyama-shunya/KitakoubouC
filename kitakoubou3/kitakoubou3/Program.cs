using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //3-1
            int x = 5;
            int y = 4;
            if (x > y)
            {
                Console.WriteLine("xはyより大きい");
            }

            //3-2
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            

            //3-3
            Console.WriteLine("cの値");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("dの値");
            int d = int.Parse(Console.ReadLine());

            if (c > d)
            {
                Console.WriteLine("cはdより大きい");
            }
            else
            {
                Console.WriteLine("cはdより小さい");
            }
            
            //3-4

            Console.WriteLine("eの値");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("fの値");
            int f = int.Parse(Console.ReadLine());

            if (e > f)
            {
                Console.WriteLine("eはfより大きい");
            }else if (e<f)
            {
                Console.WriteLine("eはfより小さい");
            }
            else
            {
                Console.WriteLine("eとfは等しい");
            }
            


            //3-5
            Console.WriteLine("整数を入力してください");
            int g = int.Parse(Console.ReadLine());
            if (g % 2 == 0)
            {
                Console.WriteLine("偶数");
            }
            else
            {
                Console.WriteLine("奇数");
            }

            //3-6
            int h = int.Parse(Console.ReadLine());
            if (h >= 0)
            {
                if (h % 2 == 0)
                {
                    Console.WriteLine("正の偶数");
                }
                else { 
                    Console.WriteLine("正の奇数");
                }
            }
            else
            {
                if (h % 2 == 0)
                {
                    Console.WriteLine("負の偶数");
                }
                else
                {
                    Console.WriteLine("負の奇数");
                }
            }
      

            //3-7
            int score = int.Parse(Console.ReadLine());
            if (score >= 60)
            {
                Console.WriteLine("合格");
            }
            else
            {
                Console.WriteLine("不合格");
            }

            if (score >= 80)
            {
                Console.WriteLine("たいへんよくできました。");
            }else if(score >= 60)
            {
                Console.WriteLine("よくできました。");
            }
            else
            {
                Console.WriteLine("ざんねんでした。");
            }

            if (score >= 80)
            {
                Console.WriteLine("優");
            }else if (score >= 70)
            {
                Console.WriteLine("良");
            }else if (score >= 60)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }

            

            //3-8
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 >= 60 && num2 >= 60)||(num1+num2>=130)||(num1+num2>=100&&(num1>=90||num2>=90)))
            {
                Console.WriteLine("合格");
            }
            else
            {
                Console.WriteLine("不合格");
            }

            

            //3-9
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            if ((day == 0) || (day == 2 && time == 0) || (day == 3 && time == 2) || (day == 5 && time == 0) || (day == 6 && time != 0)) 
            {
                Console.WriteLine("休診です");
            }
            else
            {
                Console.WriteLine("営業日");
            }
           
            //3-10

            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());

            if (i < j && i % 2 == 0&&j%2==0)
            {
                Console.WriteLine("iはjより小さく、かつ、iとjは共に偶数");
            }
            if (i == j && i < 0)
            {
                Console.WriteLine("iとjは等しく、かつ、負の数である。");
            }
            if (i < j || i % 2 == 0)
            {
                Console.WriteLine("iはjより小さい、または、xは偶数である");
            }
            if ((i <= 10 || i >= 100)&&(j>=10&&j<=100)){
                Console.WriteLine("iは10以下または100以上で、かつ、jは10以上かつ100以下である。");
            }
            if (!(i < 0 && j < 0))
            {
                Console.WriteLine("iもjも負の数である、ではない。");
            }


            //3-11
            Console.WriteLine("好きな寿司を選んでください");
            Console.WriteLine("1:まぐろ 2:えび 3:こはだ 4:ぶり");
            int sushi = int.Parse(Console.ReadLine());

            switch (sushi)
            {
                case 1:
                    Console.WriteLine("大吉");
                    break;
                case 2:
                    Console.WriteLine("吉");
                    break;
                case 3:
                    Console.WriteLine("小吉");
                    break;
                case 4:
                    Console.WriteLine("中吉");
                    break;
            }
            
            //3-12
            Console.WriteLine("好きな月を数字で入力してください");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("31日");
                    break;
                case 2:
                    Console.WriteLine("28日");
                    break;
                case 3:
                    Console.WriteLine("31日");
                    break;
                case 4:
                    Console.WriteLine("30日");
                    break;
                case 5:
                    Console.WriteLine("31日");
                    break;
                case 6:
                    Console.WriteLine("30日");
                    break;
                case 7:
                    Console.WriteLine("31日");
                    break;
                case 8:
                    Console.WriteLine("31日");
                    break;
                case 9:
                    Console.WriteLine("30日");
                    break;
                case 10:
                    Console.WriteLine("31日");
                    break;
                case 11:
                    Console.WriteLine("30日");
                    break;
                case 12:
                    Console.WriteLine("31日");
                    break;
                default:
                    Console.WriteLine("入力が間違っています");
                    break;
            }

        }
    }
}
