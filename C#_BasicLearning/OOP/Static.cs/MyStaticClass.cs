using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.cs
{
    public static class MyStaticClass
    {
         static MyStaticClass()
        {
            Console.WriteLine("Static Constructor!");
        }
         public static string MyStaticField = "hello static";
    }
}
