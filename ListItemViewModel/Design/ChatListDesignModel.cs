using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Server_Restart_Final
{
    public class ChatListDesignModel : ChatlistViewModel
    {


        public static ChatListDesignModel Instance
        => new ChatListDesignModel();

        public ChatListDesignModel()
        {

            Items = new List<ChatlistItemViewModel>
            {
                new ChatlistItemViewModel
                {
                    Name = "Server",
                    ProfilePictrue = "/Images/icons8-server-48.png",
                    Initials = "S",
                    Message = "",
                    ProfilePictrueRGB = "00000000",
                    NewContentAvailable = false,
                    TypeOfPage = ApplicationPage.Main,
                },
                   new ChatlistItemViewModel
                {
                    Name = "Settings",
                    Initials = "S",
                    ProfilePictrue = "/Images/icons8-settings-48.png",
                    Message = "",
                    ProfilePictrueRGB = "00000000",
                    NewContentAvailable = false,
                    TypeOfPage = ApplicationPage.Settings,
                },
                     new ChatlistItemViewModel
                {
                    Name = "Info",
                    Initials = "",
                    ProfilePictrue = "/Images/icons8-info-48.png",
                    Message = "",
                    ProfilePictrueRGB = "00000000",
                    NewContentAvailable = false,
                    TypeOfPage = ApplicationPage.Info,
                },
                
            };
            Global.GlobalSigh._Item = Items;
        }
    }
}