using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double DG_BonusProvider(double amount);
    public class Bonuses
    {
        public double TenPercent(double amount)
        {
            return amount / 10;
        }
        public double FlatTwoIfAmountMoreThanFive(double amount)
        {
            double result;
            if(amount > 5)
            {
                result = 2.0;
            }
            else
            {
                result = 0.0;
            }
            return result;
        }
    }
}
