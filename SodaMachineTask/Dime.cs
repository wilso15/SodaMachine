using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineTask
{
    public class Dime : Coin
    {
        public Dime(int coinValue) : base(coinValue)
        {
            coinValue = 10;
        }
    }
}
