using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTask
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period)
            : base(amount, period)
        { }

        public override decimal Income()
        {
            var currentDeposit = Amount;

            for (int i = 1; i <= Period; ++i)
            {
                // rounding deposit to hundredth
                currentDeposit += Math.Round(currentDeposit * i / 100m, 2, MidpointRounding.AwayFromZero);
            }

            return currentDeposit - Amount;
        }
    }
}
