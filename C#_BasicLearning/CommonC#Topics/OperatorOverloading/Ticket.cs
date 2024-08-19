using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Ticket
    {
        public int DurationHours { get; set; }
        public DateTime CreationDate { get; set; }

        public Ticket(int durationHours)
        {
            DurationHours = durationHours;
            CreationDate = DateTime.Now;
        }

        public static Ticket operator +(Ticket a, Ticket b)
        {
            return new Ticket(a.DurationHours + b.DurationHours);
        }
    }
}
