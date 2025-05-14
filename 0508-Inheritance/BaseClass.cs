using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_08_Inheritance
{
    /*sealed*/ class BaseClass // 
    {
        public virtual void Method()
        {
            Console.WriteLine("MyMethod");
        }
    }
    class Derived2 : BaseClass
    {
        public sealed void Method()
        {
            Console.WriteLine("DerivedMethod");
        }
    }
}
