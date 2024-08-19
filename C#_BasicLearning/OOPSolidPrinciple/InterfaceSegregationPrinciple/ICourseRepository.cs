using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface ICourseRepository
    {
        void AddCourse(Course cs);
        void EditCourse(Course cs);
        void DeleteCourse(Course cs);
    }
}
