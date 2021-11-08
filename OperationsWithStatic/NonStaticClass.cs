using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    class NonStaticClass
    {
        private int _Id;
        public static int field;
        public NonStaticClass(int Id)
        {
            _Id = Id;
        }
        public void Method()
        {
            Console.WriteLine($"Instance{_Id}.field = {field}");
        }
    }

}
