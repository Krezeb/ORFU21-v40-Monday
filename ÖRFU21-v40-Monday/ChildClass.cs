using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRFU21_v40_Monday
{
    class ChildClass : ParentClass // gives ChildClass access to everything in ParentClass (inheritance)
    {
        public ChildClass() : base(3)
        {
            Console.WriteLine($"Child skapades utan parametrar...");
        }
        public void AccessDemoChild()
        {
            //Console.WriteLine($"Private- {_privateField}"); //doesn't work as the field is set to Private in ParentClass
            Console.WriteLine($"Public- {_publicField}");
            Console.WriteLine($"Protected- {_protectedField}");
        }

    }
}
