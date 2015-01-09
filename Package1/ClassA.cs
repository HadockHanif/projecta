
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
        IDependencyInversion inversion;
        public ClassA(IDependencyInversion _inversion)
        {
            inversion = _inversion;
        }

        public void Method1()
        {

        }

        public void Method2()
        {

            inversion.MethodX();
            //ClassS s = new ClassS();
            //s.Method3();
            //s.Method1();
        }

        public void Method3()
        {
            inversion.MethodX();
            //ClassY y = new ClassY();
            //y.Method2();
            //Console.WriteLine(a);
        }
    }
}
