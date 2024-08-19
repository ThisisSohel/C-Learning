using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Course : ICourseRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddCourse(Course cs)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(Course cs)
        {
            throw new NotImplementedException();
        }

        public void EditCourse(Course cs)
        {
            throw new NotImplementedException();
        }
    }
}
