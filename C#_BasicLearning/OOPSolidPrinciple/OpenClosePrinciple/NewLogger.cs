using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class NewLogger : Logger
    {
        public string Message { get; set; }

        public NewLogger(string msg) 
        { 
            Message = msg;
        }
        public override void Info(string message)
        {
            base.Info(message);
            Console.WriteLine("Logger message " +  (Message + message));
        }
    }
}
