using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Ex
{
    public class Account
    {
        public double principal, rate; int daysActive, accountType;
        public static const int STANDARD = 0, BUDGET = 1, PREMIUM = 2, PREMIUM_PLUS = 3;
    }
}
