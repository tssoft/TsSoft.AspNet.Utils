using Ninject;

namespace TsSoft.AspNet.Utils
{
    internal class Kernel
    {
        private static StandardKernel _instance;

        public static StandardKernel Instance
        {
            get { return _instance ?? (_instance = new StandardKernel(new Bindings())); }
        }
    }
}
