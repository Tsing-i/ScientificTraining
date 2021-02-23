//系统类库
using System.Windows;
using System.Diagnostics;
//Prsim框架
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
//用户自定义
using ScientificTraining.Views;


namespace ScientificTraining
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<Dashboard>();


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        private static bool IsRunning()
        {
            int processCount = 0;
            string processName = Process.GetCurrentProcess().ProcessName;

            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName == processName)
                {
                    processCount++;
                    if (processCount > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            var result = IsRunning();

            if (!result)
            {
                Login login = new Login();
                login.ShowDialog();

                moduleCatalog.AddModule<ModuleLogic.ModuleLogicModule>();
            }
            else
            {
                MessageBox.Show("程序已经启动！");
            }
        }
    }
}
