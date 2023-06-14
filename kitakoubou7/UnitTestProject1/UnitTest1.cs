using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kitakoubou7;
using kitakoubou8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,TestCategory("カテゴリー1")]
        public void AddCoinsTest()
        {
            //AddCoinsとGetAmountがちゃんと動作するかテスト
            CoinCase cc = new CoinCase();
            cc.AddCoins(500, 10);
            cc.AddCoins(100, 10);
            cc.AddCoins(50, 10);
            cc.AddCoins(10, 10);
            cc.AddCoins(5, 10);
            cc.AddCoins(1, 10);
            cc.AddCoins(48, 10);

            int testnum = (500 + 100 + 50 + 10 + 5 + 1) * 10;

            Assert.AreEqual(cc.GetAmount(), testnum);
        }
        [TestMethod, TestCategory("カテゴリー1")]
        public void AddCoinsTestNum()
        {
            //AddCoinsとGetAmountがちゃんと動作するかテスト Amount引数ありver
            CoinCase cc = new CoinCase();
            cc.AddCoins(500, 10);
            cc.AddCoins(100, 10);
            cc.AddCoins(50, 10);
            cc.AddCoins(10, 10);
            cc.AddCoins(5, 10);
            cc.AddCoins(1, 10);
            cc.AddCoins(48, 10);

            Assert.AreEqual(cc.GetAmount(500), 5000);
        }

        [TestMethod, TestCategory("カテゴリー2")]
        public void GetCount()
        {
            //AddCoinsとGetCountがちゃんと動作するかテスト
            CoinCase cc = new CoinCase();
            cc.AddCoins(500, 10);
            cc.AddCoins(100, 10);
            cc.AddCoins(50, 10);
            cc.AddCoins(10, 10);
            cc.AddCoins(5, 10);
            cc.AddCoins(1, 10);
            cc.AddCoins(48, 10);

            Assert.AreEqual(cc.GetCount(), 60);
        }

        [TestMethod, TestCategory("カテゴリー2")]
        public void GetCountNum()
        {
            //AddCoinsとGetCountがちゃんと動作するかテスト Count引数ありver
            CoinCase cc = new CoinCase();
            cc.AddCoins(500, 10);
            cc.AddCoins(100, 10);
            cc.AddCoins(50, 10);
            cc.AddCoins(10, 10);
            cc.AddCoins(5, 10);
            cc.AddCoins(1, 10);
            cc.AddCoins(48, 10);

            Assert.AreEqual(cc.GetCount(500), 10);
        }
    }
}
