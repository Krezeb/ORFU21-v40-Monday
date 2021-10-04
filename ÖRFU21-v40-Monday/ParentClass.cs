using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRFU21_v40_Monday
{
    class ParentClass
    {
        private string _privateField;
        public string _publicField;
        protected string _protectedField;

        public string myProp { get; set; }

        public ParentClass(int x)
        {
            Console.WriteLine($"Parent skapades med {x}");
            //_privateField = "Private Field";
            //_publicField = "Public Field";
            //_protectedField = "Protected field";
        }
        public void myMethod()
        {
            Console.WriteLine($"parent method");
        }

        public void AccessDemoParent()
        {
            Console.WriteLine($"Private- {_privateField}");
            Console.WriteLine($"Public- {_publicField}");
            Console.WriteLine($"Protected- {_protectedField}");
        }
    }
}
