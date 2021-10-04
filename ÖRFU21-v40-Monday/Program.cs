using System;

namespace ÖRFU21_v40_Monday
{
    class Program
    {
        static void Main(string[] args)
        {
            //            int x1 = 5;
            //            int x2 = x1;

            //            Console.WriteLine($"x1: {x1}");
            //            Console.WriteLine($"x2: {x2}");

            //            x1 = 11;

            //            Console.WriteLine($"x1: {x1}");
            //            Console.WriteLine($"x2: {x2}");

            //            MyClass m1 = new MyClass(){ MyValue = 20};
            //            MyClass m2 = m1;

            //            Console.WriteLine($"m1: {m1.MyValue}");
            //            Console.WriteLine($"m2: {m2.MyValue}");

            //            m1.MyValue = 11;

            //            Console.WriteLine($"m1: {m1.MyValue}");
            //            Console.WriteLine($"m2: {m2.MyValue}");

            ////NULL----------------------------------------------------------------

            string s = null;
            int[] ii = null;
            MyClass mc = null;

            string s2 = null;
            if (Console.ReadLine() == "y")
            {
                s2 = "yes";
            }
            else
            {
                s2 = "no";
            }

            //Console.WriteLine($"{s.Length}"); // will throw a null point exception error.
            if (s != null)
            {
                Console.WriteLine($"{s.Length}");
            }
            if (s == null)
            {
                Console.WriteLine($"Variable is null. ERROR.");
            }
            Console.WriteLine($"{s?.Length}"); // (null conditional) null if s has a Length, it prints. If s doesn't have a length (is null), entire bit becomes null.

            string result = s ?? "hej"; // (null-coalescing) If s is null, use "hej" instead (null-coalescing)
            Console.WriteLine($"result = {result}");

            MyClass m3 = null;
            int theValue = m1?.MyValue ?? 0; //(null conditional) + (null-coalescing)
            Console.WriteLine($"theValue: {theValue}");

            //Inheritance----------------------------------------------------------------

            ChildClass cc = new ChildClass();
            cc.myMethod();

            //ChildClass cc2 = new ChildClass(6);
            //cc2.myMethod();

            ChildClass accessDemo1 = new ChildClass();
            accessDemo1.AccessDemoChild();

            ParentClass child1 = new ChildClass();
            child1.AccessDemoParent();
            //child1.AccessDemoChild(); //Kommer vi inte åt eftersom child1 är av typen ParentClass.

            ChildClass child2 = new ChildClass();
            child2.AccessDemoParent();
            child2.AccessDemoChild(); //Nu kommer den åt.

            //ChildClass child3 = child1; //Doesn't work because child1 is of type ParentClass (Line 76)
            ChildClass child3 = (ChildClass)child1; // It is possible to force using casting
            child3.AccessDemoParent();
            child3.AccessDemoChild(); //Casting will allow us to access this.

            ParentClass child4 = new ParentClass(8);
            //ChildClass child5 = (ChildClass)child4; // will crash 

            if (child4.GetType() == typeof(ChildClass)) //This is how to check what TYPE OF CLASS a variable is.
            {
                Console.WriteLine($"är en ChildClass");
            }
            else
            {
                Console.WriteLine($"Is not a ChildClass. Type is {child4.GetType()}");
            }

            ChildClass child6 = child4 as ChildClass; //Will give child6 the same as child4 and cast as a ChildClass.
            if (child6 == null)
            {
                Console.WriteLine("child6 is null"); //nullcheck
            }

            ChildClass child7 = child1 as ChildClass;
            if(child7 != null)
            {
                Console.WriteLine("child1 as ChildClass is valid");
            }

            if (child4 is ChildClass child8)
            {
                Console.WriteLine("child4 is ChildClass instance."); //nullcheck
            }
            else
            {
                Console.WriteLine("child4 is NOT ChildClass instance.");
            }
        }
    }
}
