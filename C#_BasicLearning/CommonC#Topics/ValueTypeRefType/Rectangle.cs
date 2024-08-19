using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeRefType
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }

        void ModifyRectangle(Rectangle rect)
        {
            rect.width = width;
            rect.height = height;
        }
    }
}
