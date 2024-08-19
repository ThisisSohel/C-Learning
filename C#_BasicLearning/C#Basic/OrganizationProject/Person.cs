using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationProject
{
    public class Person 

    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public void InfoSet(int id, string name)
        {
            Id = id;
            Name = name;    
        }
        public virtual void BasicInfoPrint() 
        {
            Console.WriteLine($" Id = {Id}");
            Console.WriteLine($" Name = {Name}");
        }
    }
}
