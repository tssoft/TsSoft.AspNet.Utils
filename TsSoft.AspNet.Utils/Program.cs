using System;
using System.Windows.Forms;
using Ninject;

namespace TsSoft.AspNet.Utils
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Kernel.Instance.Get<GeneratorForm>());
        }
    }
}
