using Package2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassL : IDependencyInversion5
    {
        /*private IInterfaceP _ip;

        public ClassL(IInterfaceP ip)
        {
            _ip = ip;
        }*/
        

        public void Method1()
        {

            ClassP p = new ClassP();
            p.Method10();
        }

        public void MethodT()
        {
            Method1();
        }
    }
}
