using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.cs
{


    public interface IFirstInterface
    {
        public void FirstMethod();

    }
    public interface ISecondInterface
    {
        public void SecondMethod();
    }

    public class Demo : IFirstInterface, ISecondInterface
    {
        public void FirstMethod()
        {
            Console.WriteLine("Fisrt method");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second method");

        }
    }

}
