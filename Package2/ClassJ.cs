using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassJ
    {
        IDependencyInversion3 iDependencyInversion3;

        public ClassJ(IDependencyInversion3 _iDependencyInversion3)
        {
            iDependencyInversion3 = _iDependencyInversion3;
        }
        public ClassJ()
        {
        }

        public void Method1()
        {
            iDependencyInversion3.MethodW();
            //ClassK k = new ClassK();
            //k.Method1();
        }
    }
}
