using System.Windows.Media;
using System.Windows.Input;
using System;

namespace Server_Restart_Final
{
    public class ChatlistItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        public string ProfilePictrueRGB { get; set; }
        public string ProfilePictrue { get; set; }
        public bool NewContentAvailable { get; set; }
        public bool IsSelected { get; set; } 
        public ApplicationPage TypeOfPage { get; set; }
        public ICommand OpenPageCommand { get; set; }
        public ChatlistItemViewModel()
        {
            OpenPageCommand = new RelayCommand(OpenPage);
        }
        public void OpenPage()
        {
            Global.GlobalSigh.ChangeSideBar(NewContentAvailable);
            Global.GlobalSigh.GlobalMethod(TypeOfPage);
        }
    }
}
