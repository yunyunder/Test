using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMoney
{
    internal class CoinChanger
    {
        public int CalculateChangeNumber(int cointype, int nowTotal)
        {
            int coinnum = 0;
            while (nowTotal >= cointype)
            {
                nowTotal -= cointype;
                coinnum++;
            }
            return coinnum;
        }
    }
}
