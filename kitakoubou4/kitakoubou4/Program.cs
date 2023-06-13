using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //4-1
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("SPAM");
            }
        

            //4-2
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(3 * i);
            }

            //4-3
            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

            //4-4 答え見ないとわからなかった問題
            int x = 1;
            for (int i = 2; i <=7; i++)
            {
                x *= i;
            }
            Console.WriteLine(x);

           
            //4-5
            int y = 0;
            for(int i = 0; i < 10; i++)
            {
                int z = int.Parse(Console.ReadLine());
                y += z;
            }
            Console.WriteLine("平均:"+y / 10);

            //4-6
            int win = 0;
            int lose = 0;
            Console.WriteLine("勝ちを1,負けを0として10回入力");
            for(int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    win++;
                }
                else
                {
                    lose++;
                }
            }
            Console.WriteLine("勝ちの総数:" + win);
            Console.WriteLine("負けの総数:" + lose);
            
            
            //4-7
            int kyojin = 0;
            int hanshin = 0;
            Console.WriteLine("巨人対阪神");
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(i + "回表、巨人の得点は？");
                int num1 = int.Parse(Console.ReadLine());
                kyojin += num1;

                Console.WriteLine(i + "回裏、阪神の得点は？");
                int num2 = int.Parse(Console.ReadLine());
                hanshin += num2;
            }
            Console.WriteLine("巨人:" + kyojin + "点,阪神:" + hanshin+"点");
            if (kyojin > hanshin)
            {
                Console.WriteLine("巨人の勝ち");
            }
            else if(hanshin>kyojin)
            {
                Console.WriteLine("阪神の勝ち");
            }
            else
            {
                Console.WriteLine("引き分け");
            }

            

            //4-8
            int maxnum = 0;
            for(int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (maxnum < num)
                {
                    maxnum = num;
                }
            }
            Console.WriteLine("最大値:"+maxnum);

            
            //4-9
            int maxnum2=0;
            int minnum = 0;
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    maxnum2 = num;
                    minnum = num;
                }
                if (maxnum2 < num)
                {
                    maxnum2 = num;
                }
                if (minnum > num)
                {
                    minnum = num;
                }
            }
            Console.WriteLine("最大値:" + maxnum2);
            Console.WriteLine("最小値:" + minnum);

            

            //4-10
            Console.WriteLine("適当な数値を打って");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            //4-11
            Console.WriteLine("適当な数値を打って");
            int number2 = int.Parse(Console.ReadLine());

            for(int i = 0; i < number2; i++)
            {
                Console.Write(i % 10);
            }
            Console.Write("\n");
              
            
            //4-12
            int sumnum = 0;
            while (sumnum < 100)
            {
                int num = int.Parse(Console.ReadLine());
                sumnum += num;
            }
            Console.WriteLine("合計:" + sumnum);
            
            //4-13
            int strike = 0;
            int ball = 0;
            while (strike < 3 && ball < 4)
            {
                Console.WriteLine("ストライク=1 or ボール=2 ？");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    strike++;
                }else if (num == 2)
                {
                    ball++;
                }
                else
                {
                    Console.WriteLine("無効な値です");
                }
            }
            Console.WriteLine(ball+"ボール,"+strike+"ストライク");
            
            //4-14
            int strike2 = 0;
            int ball2 = 0;
            while (strike2 < 3 && ball2 < 4)
            {
                Console.WriteLine("ストライク=1 or ボール=2 orファール=3？");
                int num = int.Parse(Console.ReadLine());
                if (num == 1||(num==3&&strike2<2))
                {
                    strike2++;
                }
                else if (num == 2)
                {
                    ball2++;
                }

            }
            Console.WriteLine(ball2 + "ボール," + strike2 + "ストライク");
            
            //4-15 答え見ました
            //素因数分解：小さい素数から割っていき最後の余りが素数になるまでやる分解方法
            Console.WriteLine("整数を入力して");
            int fact = int.Parse(Console.ReadLine());
            for(int i = 2; fact >1 ; i++)   //条件式：初期値が2,終了条件がfactが１になったら（全部割り切れたら）
            {
                while (fact % i == 0)   //factがiで割り切れなかったら繰り返し終了
                {
                    Console.Write("{0} ", i);   
                    fact /= i;  //iで割り切れる限りiで割っていく
                                //素数以外が出た場合に絶対に割り切れないので問題ない　例:2で割り切れいない数は4でも絶対割り切れない。
                }
            }
            Console.Write("\n");

            //4-16
            Console.WriteLine("素数判定プログラム");
            int prime = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("素数です");
            }
            else
            {
                Console.WriteLine("素数ではありません");
            }

            
            //4-17
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    int z = i * j;
                    Console.Write("{0,2}",z);
                    Console.Write(",");
                }
                Console.Write("\n");
            }
            
            //4-18
            int allnum = 0;
            Console.WriteLine("整数を入力してください。0で合計を出力");
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                allnum += num;
            }
            Console.WriteLine("合計:" + allnum);

            
            //4-19
            int count = 0;
            int allnum2 = 0;
            Console.WriteLine("整数を入力してください。0で平均を出力。最初に0を打ってはいけない");
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                allnum2 += num;
                count++;
            }
            if (!(count == 0)) 
            {
                Console.WriteLine("平均:" + allnum2 / count);
            }
            else
            {
                Console.WriteLine("数値が入力されなかったため無効です。");
            }

            //4-20
            Console.WriteLine("サイズを整数で指定してください");
            int num20 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num20; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.Write("\n");
            }
            
            //4-21
            Console.WriteLine("サイズを整数で指定してください");
            int num21 = int.Parse(Console.ReadLine());

            for(int i = 0; i < num21; i++)
            {
                for(int j = 0; j < num21; j++)
                {
                    if (i == j || (num21 - i-1) == j)
                    {
                        Console.Write("×");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

            //4-22
            int num22A = 0;
            int num22B = 1;
            while (true)
            {
                if (num22A < 1000) {
                    Console.Write(num22A + ",");
                }
                else
                {
                    break;
                }
                if (num22B < 1000)
                {
                    Console.Write(num22B + ",");
                }
                else
                {
                    break;
                }
                num22A += num22B;
                num22B += num22A;
            }
        }
    }
}
