using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;

namespace Package3
{
    public class ClassY : IDependencyInversion1
    {
        public int Method2()
        {
            return 5;
        }



        public void MethodX()
        {
            
        }

        public int MethodY()
        {
            return Method2();
        }
    }
}
