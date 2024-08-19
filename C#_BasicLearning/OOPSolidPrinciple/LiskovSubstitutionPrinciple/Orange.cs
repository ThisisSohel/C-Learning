using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
