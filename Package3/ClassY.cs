using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;

namespace Package3
{
    public class ClassY : IDependencyInversion
    {
        public int Method2()
        {
            return 5;
        }

        /*int MethodX()
        {
            return Method2();
        }
        DateTime MethodY()
        {
            return 0;
        }*/





        public int MethodX()
        {
            throw new NotImplementedException();
        }

        public DateTime MethodY()
        {
            throw new NotImplementedException();
        }
    }
}
