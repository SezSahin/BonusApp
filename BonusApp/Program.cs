using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order O = new Order();
            Bonuses B = new Bonuses();
            DG_BonusProvider DGB;
            DGB = new DG_BonusProvider(B.FlatTwoIfAmountMoreThanFive);
            DGB(1);
            DGB = new DG_BonusProvider(B.TenPercent);
            DGB(25);
        }
    }
}
