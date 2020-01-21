using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Methods;

namespace TaskRoom
{
    public class LeaderboardPage : ContentPage
    {
        public LeaderboardPage()
        {
            GetSetDB Hammad = new GetSetDB();
            string Testmessage;
            Testmessage = Hammad.NewGetReq();
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = Testmessage }
                }
            };
        }
    }
}