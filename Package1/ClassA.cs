using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//abu hanifa
namespace Package1
{
    public class ClassA
    {
        IDependencyInversion1 iDependencyInversion1;


        public ClassA(IDependencyInversion1 _iDependencyInversion1)
        {
            iDependencyInversion1 = _iDependencyInversion1;
        }
        public ClassA()
        {

        }
        
        public void Method1()
        {

        }

        public void Method2()
        {

            iDependencyInversion1.MethodX();
            //ClassS s = new ClassS();
            //s.Method3();
            //s.Method1();
        }

        public void Method3()
        {
            iDependencyInversion1.MethodY();    
            //ClassY y = new ClassY();
            //y.Method2();
            //Console.WriteLine(a);
        }

        
    }
}
