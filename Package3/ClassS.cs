using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;

namespace Package3
{
    public class ClassS : IDependencyInversion
    {
        public void Method1()
        {

        }

        public void Method2()
        {

        }

        public void Method3()
        {

        }

        public int MethodX()
        {
            Method1();
            Method2();
            Method3();
            return 0;
        }

        public DateTime MethodY()
        {
            throw new NotImplementedException();
        }
    }
}
