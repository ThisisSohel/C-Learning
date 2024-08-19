using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public  class Logger
    {
        public virtual void Info(string message)
        {
            Console.WriteLine("Info Virual " + message);
        }

        public virtual void Log(string message)
        {
            Console.WriteLine( "log virtual " + message);
        }

        public virtual void Debug(string message)
        {
            Console.WriteLine("Debug " + message);
        }
    }
}
