using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassO
    {
        IDependencyInversion4 iDependencyInversion4;

        public ClassO(IDependencyInversion4 _iDependencyInversion4)
        {
            iDependencyInversion4 = _iDependencyInversion4;

        }

        public void Method2()
        {
            iDependencyInversion4.MethodV();
            //ClassT t = new ClassT(new ClassE());
            //t.Method2();
        }
    }
}
