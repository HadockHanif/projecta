using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;


namespace Package3
{
    public class ClassS : IDependencyInversion1
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





        public void MethodX()
        {
            Method1();
            Method2();
            Method3();
        }

        public int MethodY()
        {
            return 0;   
        }


        
    }
}
