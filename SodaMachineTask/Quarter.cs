using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineTask
{
    public class Quarter : Coin
    {
        public Quarter(int coinValue) : base(coinValue)
        {
            this.coinValue = 25;
        }
    }
}
