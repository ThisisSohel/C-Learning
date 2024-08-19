using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading.cs
{
    public class Interest
    {
        public double ABCBank (double rate, double amount)
        {
            return rate * amount;
        }
        public double ABCBank(int rate, double amount)
        {
            return rate * amount;
        }
        public double ABCBank(double rate, double amount, int hourlyIncome)
        {
            return rate * amount * hourlyIncome;
        }
    }

    public class X
    {
        public virtual void A()
        {

        }
    }
    public class Y : X
    {
        public override void A()
        {
            base.A();
        }
    }

    public class Z : Y
    {
        public override void A()
        {
            base.A();
        }
    }
}
