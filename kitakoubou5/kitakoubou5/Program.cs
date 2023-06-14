using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //5-1
            int[] array1 = new int[10];
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            foreach(int value in array1)
            {
                Console.Write(value * 2+",");
            }

            
            //5-2
            int[] array2 = new int[10];
            for(int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[array2.Length-i-1]+",");
            }
            
            //5-3
            int[] array3 = new int[10];
            string even = "";
            string odd = "";
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = int.Parse(Console.ReadLine());
            }
            foreach(int value in array3)
            {
                if (value % 2 == 0)
                {
                    even += value+" ";
                }
                else
                {
                    odd += value+" ";
                }
            }
            Console.WriteLine("偶数:"+even);
            Console.WriteLine("奇数:" + odd);

            
            //5-4
            int[] array4 = new int[10];
            int num4 = 0;
            int count = 0;
            for (int i = 0; i < array4.Length &&num4<100; i++)
            {
                array4[i] = int.Parse(Console.ReadLine());
                num4 += array4[i];
                count++;
            }
            for (int i= 0;i<count;i++)
            {
                Console.Write(array4[i] + ",");
            }

            
            //5-5

            int num5 = int.Parse(Console.ReadLine());

            int[] binary = new int[16];

            // 配列 binaryに0か1を代入する
            for (int i = 0; i < 16; i++)
            {
                if (num5 % 2 == 0)
                {
                    binary[15 - i] = 0;
                    num5 /= 2;
                }
                else
                {
                    binary[15 - i] = 1;
                    num5 /= 2;
                }
            } 

            for (int i = 0; i < 16; i++)
            {
                Console.Write(binary[i]);
            }
            
            //5-6
            int[,] kuku = new int[9, 9];

            // 配列 kuku に値を代入する
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kuku[i, j] = (i+1) * (j+1);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(" {0,2}", kuku[i, j]);

                Console.WriteLine();
            }
            
            //5-7
            int[,] kuku2 = new int[9, 9];

            // 配列 kuku に値を代入する
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kuku2[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("整数を2回入力");
            int num7_1 = int.Parse(Console.ReadLine());
            int num7_2 = int.Parse(Console.ReadLine());

            Console.WriteLine(kuku2[num7_1-1, num7_2-1]);
            

            //5-8

            Console.WriteLine("整数を10回入力");
            int[] list=new int[10];
            for(int i = 0; i < 10; i++)
            {
                int num8 = int.Parse(Console.ReadLine());
                list[i] = num8;
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = i+1; j < 10; j++)
                {
                    int number;
                    if (list[i] > list[j])
                    {
                        number = list[i];
                        list[i] = list[j];
                        list[j] = number;
                    }
                }
            }
            

            foreach(int value in list)
            {
                Console.Write("{0},",value);
            }
        }
    }
}
