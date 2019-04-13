using ServerRestartFinal.Core.IoC;
using ServerRestartFinal.Core.IoC.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Server_Restart_Final
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        public static Random Rand;
        public App() : base()
        {
            ProcessCheckStatus.data = DataStorage.StorageData.FromXmlFile<DataStorage.Data>(System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            Rand = new Random();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoC.Setup();

            IoC.Kernel.Bind<ILogFactory>().ToConstant(new BaseLogFactory());

           IoC.Logger.Log("Application Starting Up...");
        }
    }
}
