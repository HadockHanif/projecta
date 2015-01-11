using Package2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassT : IDependencyInversion4
    {
        /*private IInterfaceE _ie;

        public ClassT(IInterfaceE ie)
        {
            _ie = ie;
        }*/

        public void Method2()
        {
            ClassX x = new ClassX();
            x.Method1();
            ClassE e = new ClassE();
            e.Method5();
        }

        public void MethodV()
        {
            Method2();
        }
    }
}
