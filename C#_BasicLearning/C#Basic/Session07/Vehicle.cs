using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07
{
    public class Vehicle
    {
        protected string Type { get; set; }

        /// <summary>
        /// This property always returns a value &lt; 1.
        /// </summary>
        public void PrintVehicleType()
        {
            Console.WriteLine(Type);
        }

    }
}
