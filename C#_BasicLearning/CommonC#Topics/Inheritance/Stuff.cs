using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Stuff : Person
    {
        public string Ref
        {
            get { return RefId; }
            set { RefId = "stuff-" + value; }
        }
    }
}
