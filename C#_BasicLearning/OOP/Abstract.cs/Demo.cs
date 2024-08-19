using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.cs
{
    public abstract class Demo
    {
        protected int _x = 100;
        protected int _y = 200;

        public abstract void AbsMethod();

        public abstract int X { get;}
        public abstract int Y { get;}
    }

    public class Demo1 : Demo
    {
        public override void AbsMethod()
        {
            _x++;
            _y++;
        }

        public override int X
        {
            get { return _x+10; }
        }
        public override int Y
        {
            get { return _y+10; }
        }
    }
}
