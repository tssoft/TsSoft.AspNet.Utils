using Ninject.Modules;
using TsSoft.AspNet.Utils.Services;

namespace TsSoft.AspNet.Utils
{
    internal class Bindings: NinjectModule
    {
        public override void Load()
        {
            Bind<IPasswordGenerator>().To<PasswordGenerator>().InSingletonScope();
        }
    }
}
