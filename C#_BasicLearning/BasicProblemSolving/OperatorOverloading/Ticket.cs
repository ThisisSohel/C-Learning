using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Ticket
    {
        public int DurationInHours { get; set; }
        public DateTime CreationTime { get; set; }

        public Ticket(int duration)
        {
            DurationInHours = duration;
            CreationTime = DateTime.Now;
        }

        public static Ticket operator + (Ticket t1, Ticket t2)
        {
            return new Ticket(t1.DurationInHours + t2.DurationInHours);
        }

        public static Ticket operator - (Ticket t1, Ticket t2)
        {
            return new Ticket (t1.DurationInHours - t2.DurationInHours);
        }

        public static Ticket operator * (Ticket t1, Ticket t2)
        {
            return new Ticket(t1.DurationInHours * t2.DurationInHours);
        }

        public static Ticket operator / (Ticket t1, Ticket t2)
        {

            return new Ticket (t1.DurationInHours / t2.DurationInHours);
        }

        public static Ticket operator ++ (Ticket t1)
        {
            return new Ticket (++t1.DurationInHours);   
        }

        public static Ticket operator --(Ticket t1)
        {
            return new Ticket(--t1.DurationInHours);
        }
    }
}
