using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassW : IDependencyInversion
    {
        private IInterfaceSomething _something;
        private IDependencyInversion dependencyInversion;

        public ClassW(IInterfaceSomething something)
        {
            _something = something;
        }

        public ClassW(IDependencyInversion dependencyInversion)
        {
            // TODO: Complete member initialization
            this.dependencyInversion = dependencyInversion;
        }

        public int Method2()
        {
            return new ClassY().Method2();
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }

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
