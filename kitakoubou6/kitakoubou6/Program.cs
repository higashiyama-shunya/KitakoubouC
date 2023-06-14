using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-1
            Console.WriteLine(Power(16));
            //6-2
            Console.WriteLine(GetAvg(9, 88));
            //6-3
            int x = 19;
            int y = 9;
            int z = 12;
            Console.WriteLine(NumCom(NumCom(x, y), NumCom(y, z)));
            //6-4
            MakeTri(3);
            //MakeTri(4);
            //MakeTri(5);            
            
            //6-5
            MakeTriangle(4,'A');
            //MakeTriangle(5, 'O');
            //MakeTriangle(6, '?');
            
            //6-6
            for(int i = 1; i < 10; i++)
            {
                Kuku(i);
            }
            //6-7
            for(int i = 1; i < 1000; i++)
            {
                if (CheckPrime(i))
                {
                    Console.Write("{0},",i);
                }
            }
            
        }
        //6-1
        public static int Power(int num)
        {
            return num*num;
        }

        //6-2
        public static int GetAvg(int num,int num2)
        {
            return (num + num2) / 2;
        }

        //6-3
        public static int NumCom(int num,int num2)
        {
            if (num < num2)
            {
                return num2;
            }
            else
            {
                return num;
            }
        }

        //6-4
        public static void MakeTri(int num)
        {
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        //6-5
        public static void MakeTriangle(int num,char parts)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(parts);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        
        //6-6
        public static void Kuku(int num)
        {
            for(int i = 1; i < 10; i++)
            {
                Console.Write(" {0,2}",(num * i));
            }
            Console.Write("\n");
        }
        
        //6-7
        public static Boolean CheckPrime(int num)
        {
            bool isPrime = true;
            if (num == 1) isPrime=false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
