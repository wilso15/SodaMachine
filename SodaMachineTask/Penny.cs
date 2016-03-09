using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineTask
{
    public class Penny : Coin
    {
        public Penny(int coinValue) : base(coinValue)
        {
            this.coinValue = 1;
        }
    }
}
