using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;

namespace Server_Restart_Final
{
    public class PostsViewModel : INotifyPropertyChanged
    {
        public Posts posts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public ICommand UpdateTitleName { get { return new RelayCommands(UpdateTitleExecute, CanUpdateTitleExecute); } }

        public PostsViewModel()
        {
            posts = new Posts { postsText = "", postsTitle = "Unknown" };
        }

        public string PostsTitle
        {
            get { return posts.postsTitle; }
            set
            {
                if (posts.postsTitle != value)
                {
                    posts.postsTitle = value;
                    RaisePropertyChanged("postsTitle");
                }
            }
        }


        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        void UpdateTitleExecute()
        {
            PostsTitle = "NENENENENENE";
        }


        bool CanUpdateTitleExecute()
        {
            return true;
        }
    }
    public class Posts
    {
        public string postsText = "";
        public string postsTitle = "Unknown";
    }
}
