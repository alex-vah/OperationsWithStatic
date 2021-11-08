using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    class StaticConstructor
    {
        public static readonly long field = 2;

        public long Method()
        {
            return field;
        }
        static StaticConstructor()
        {
            field = 1; 
        }
    }
}
