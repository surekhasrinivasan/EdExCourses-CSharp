using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_InterfaceDemo
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }

        int AddPoints(decimal transactionValue);

        void ResetPoints();
    }
}
