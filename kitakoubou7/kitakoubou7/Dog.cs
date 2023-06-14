using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou7
{
    class Dog
    {
        private string mName = "";    // 名前
        private int mAge = 0;
        private string mBreed = "";

        public Dog(string breed)
        {
            mBreed = breed;
        }


        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }

        public void ShowProfile()
        {
            Console.WriteLine("\n犬種:{0}\n名前:{1}\n年齢:{2}",mBreed,mName,mAge);
        }
    }
}
