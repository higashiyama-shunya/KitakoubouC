using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou8
{
    class Dog:Animal
    {
        public Dog(String name,int age) : base(name, age)
        {
        }

        public void Run()
        {
            Console.WriteLine("トコトコ");
        }

        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }
    }
}
