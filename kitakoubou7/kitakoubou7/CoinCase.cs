using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitakoubou7
{
    class CoinCase
    {
        private int fiveHundred = 0;
        private int oneHundred = 0;
        private int fifty = 0;
        private int ten = 0;
        private int five = 0;
        private int one = 0;

        public void AddCoins(int coin,int num)
        {
            if (coin == 500)
            {
                fiveHundred+=num;
            }else if (coin == 100)
            {
                oneHundred += num;
            }else if (coin == 50)
            {
                fifty += num;
            }else if (coin == 10)
            {
                ten += num;
            }else if (coin == 5)
            {
                five += num;
            }else if (coin == 1)
            {
                one += num;
            }
        }

        public int GetCount()
        {
            return fiveHundred + oneHundred + fifty + ten + five + one;
        }


        public int GetCount(int coin)
        {
            if (coin == 500)
            {
                return fiveHundred;
            }else if (coin == 100)
            {
                return oneHundred;
            }
            else if (coin == 50)
            {
                return fifty;
            }
            else if (coin == 10)
            {
                return ten;
            }
            else if (coin == 5)
            {
                return five;
            }
            else if (coin == 1)
            {
                return one;
            }
            return -1;
        }

        public int GetAmount()
        {
            return fiveHundred * 500 + oneHundred * 100 + fifty * 50 + ten * 10 + five * 5 + one;
        }

        public int GetAmount(int coin)
        {
            if (coin == 500)
            {
                return fiveHundred*500;
            }
            else if (coin == 100)
            {
                return oneHundred*100;
            }
            else if (coin == 50)
            {
                return fifty*50;
            }
            else if (coin == 10)
            {
                return ten*10;
            }
            else if (coin == 5)
            {
                return five*5;
            }
            else if (coin == 1)
            {
                return one;
            }
            else
            {
                return -1;
            }
        }

    }
}
