using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package2;
using Package3;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IDependencyInversion>().To<ClassY>();
        }
    }
}
