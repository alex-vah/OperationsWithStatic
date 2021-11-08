using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    class NonStaticClass2
    {
        private int _id;

        public NonStaticClass2(int id)
        {
            _id = id;
        }

        public static void Method()
        {

            Console.WriteLine("No nonstatic members in a static method");
        }
    }
}
