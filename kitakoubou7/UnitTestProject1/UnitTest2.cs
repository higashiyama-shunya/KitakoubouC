using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kitakoubou8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod,TestCategory("カテゴリー1")]
        public void DogCatAbility()
        {
            //それぞれ固有のメソッドを実行して正しく動くか
            Dog dog = new Dog("タロウ",5);
            Cat cat = new Cat("コマ",4);


            Assert.AreEqual(dog.Run(), "トコトコ");
            Assert.AreEqual(cat.Sleep(), "スースー");
        }

        [TestMethod, TestCategory("カテゴリー2")]
        public void DogCatSpeak()
        {
            //Speakメソッドでそれぞれ違う結果を返しているか
            Dog dog = new Dog("タロウ", 5);
            Cat cat = new Cat("コマ", 4);

            Assert.AreEqual(dog.Speak(), "ワンワン");
            Assert.AreEqual(cat.Speak(), "ニャー");
        }

        [TestMethod, TestCategory("カテゴリー3")]
        public void DogCatNameAge()
        {
            Dog dog = new Dog("タロウ", 5);
            Cat cat = new Cat("コマ", 4);

            Assert.AreEqual(dog.Name,"タロウ");
            Assert.AreEqual(dog.Age, 5);
            Assert.AreEqual(cat.Name, "コマ");
            Assert.AreEqual(cat.Age, 4);

        }
    }
}
