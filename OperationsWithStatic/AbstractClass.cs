using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    abstract class AbstractClass
    {
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }
        public abstract void Method();
    }
}
