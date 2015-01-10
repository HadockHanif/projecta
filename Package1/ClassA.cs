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
        IDependencyInversion2 iDependencyInversion2;

        public ClassA()
        {

        }
        public ClassA(IDependencyInversion2 _iDependencyInversion2)
        {
            iDependencyInversion2 = _iDependencyInversion2;
        }
        
        public ClassA(IDependencyInversion1 _iDependencyInversion1)
        {
            iDependencyInversion1 = _iDependencyInversion1;
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
            iDependencyInversion2.MethodZ();    
            //ClassY y = new ClassY();
            //y.Method2();
            //Console.WriteLine(a);
        }

        
    }
}
