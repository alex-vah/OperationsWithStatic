using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    class StaticConstructor2
    {
        private static int field;
        public static int Property()
        {
            return field;
        }

        //static constructor works first no matter what
        static StaticConstructor2()
        {
            Console.WriteLine("Static Constructor - StaticConstructor()");
            field = 1;
        }
        public static void Method()
        {
            Console.WriteLine("Stataic method of nonstatic class");
        }
        public static void Method(int a)
        {
            Console.WriteLine("overloaded static method of nonstatic class"+a);
        }
        public void NonStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
