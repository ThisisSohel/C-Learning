using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationProject
{
    public class Teacher : Person
    {
        public string Designation {  get; set; }

        public void Test(int id, string name, string designation)
        {
            InfoSet(id, name);
            Designation = designation;
        }
        public virtual void TeacherInfo()
        {
            base.BasicInfoPrint();
            Console.WriteLine($"Designation = {Designation}");
        }
    }
}
