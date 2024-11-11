using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTask
{
    public class LongDeposit : Deposit
    {
        private const decimal _monthRate = 0.15m;

        public LongDeposit(decimal amount, int period)
            : base(amount, period)
        { }

        public override decimal Income()
        {
            if (Period <= 6)
            {
                return 0;
            }

            var currentDeposit = Amount;

            for (int i = 7; i <= Period; ++i)
            {
                // rounding deposit to hundredth
                currentDeposit += Math.Round(currentDeposit * _monthRate, 2, MidpointRounding.AwayFromZero);
            }

            return currentDeposit - Amount;
        }
    }
}
