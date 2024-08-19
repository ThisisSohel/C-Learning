using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class News 
    {
        public void FactoryInfo(List<Factory> factories)
        {
            foreach (Factory fact in factories)
            {
                fact.Info();
            }
        }
    }
}
