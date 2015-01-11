using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassP //: IInterfaceP
    {
        IDependencyInversion5 iDependencyInversion5;

        public ClassP()
        {

        }
        public ClassP(IDependencyInversion5 _iDependencyInversion5)
        {
            iDependencyInversion5 = _iDependencyInversion5;
        }
        public void Method2()
        {

        }

        public void Method9()
        {
            
        }

        public string Method10()
        {
            iDependencyInversion5.MethodT();
            return "new year ";
        }
    }
}
