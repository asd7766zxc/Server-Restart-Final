using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    class ServerPageViewModel:BaseViewModel
    {
        public ServerPage ServerPage { get; set; }
        public string SampleBiding { get; set; } = "Yess";
        public ServerPageViewModel(ServerPage serverpage)
        {
            ServerPage = serverpage;
            ServerPage.Loaded += ServerPage_Loaded;
        }

        private void ServerPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var MICVM = new MoveItemControlViewModel(ServerPage.OutPut, ServerPage.MainGrid);
            var MICVMS = new MoveItemControlViewModel(ServerPage.Samplebutton, ServerPage.MainGrid);
            var MICVMSA = new MoveItemControlViewModel(ServerPage.IoCOutPut, ServerPage.MainGrid);
            var MICVMSAS = new MoveItemControlViewModel(Global.GlobalSigh.fr,Global.GlobalSigh.mw.MainGrid);
        }
    }
}
