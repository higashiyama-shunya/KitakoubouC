using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou8
{
    class Cat : Animal
    {

        public Cat(string name, int age) : base(name, age)
        {

        }
        public void Sleep()
        {
            Console.WriteLine("スースー");
        }

        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
    }
}
