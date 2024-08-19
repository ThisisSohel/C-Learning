using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BigCat : Cat
    {
        public void BigcatInfo()
        {
            AnimalInfo();
            CatInfo();
            Console.WriteLine("BigCat......;");
        }
    }
}
