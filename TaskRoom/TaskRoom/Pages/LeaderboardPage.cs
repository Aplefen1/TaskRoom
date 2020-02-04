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
        public Webservice Connection = new Webservice();
        public Label abc = new Label { Text = "TEst" };

        public LeaderboardPage()
        {
            Button sub = new Button
            {
                Text = "View Classes"
            };
            sub.Clicked += SubOnClicked;
            StackLayout ssdsdnt = new StackLayout();
            ssdsdnt.Children.Add(abc);
            ssdsdnt.Children.Add(sub);
            Content = ssdsdnt;
        }

        public void SubOnClicked(object Sender, EventArgs args)
        {
            Connection.getClassrooms();
            abc.Text = Connection.returnedClasses;
        }
        
    }
}