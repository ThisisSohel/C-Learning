using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndEncaptulationPrinciple
{
    public abstract class InputValidator
    {
        public abstract bool ValidateEmail(string email);
        public abstract bool ValidatePassword(string password);
    }
}
