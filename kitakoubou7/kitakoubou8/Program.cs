using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //8-1～8-4
            Cat cat = new Cat("タマ",7);
            Dog dog = new Dog("タロー", 11);

            cat.ShowProfile();
            dog.ShowProfile();


            cat.Sleep();
            dog.Run();

            cat.Speak();
            dog.Speak();
            */

            //8-6
            Animal[] animalList = new Animal[4];
            animalList[0] = new Cat("タマ",4);
            animalList[1] = new Dog("コタロ", 7);
            animalList[2] = new Cat("うめ", 6);
            animalList[3] = new Dog("ムサシ", 11);

            foreach(Animal animal in animalList)
            {
                animal.ShowProfile();
                animal.Speak();
            }
        }
    }
}
