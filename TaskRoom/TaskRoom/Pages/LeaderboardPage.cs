using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;
using TaskRoom.Methods;
using TaskRoom.Objects;

namespace TaskRoom
{
    public class LeaderboardPage : ContentPage
    {
        public Webservice Connection = new Webservice();
        public Label abc = new Label { Text = "TEst" };
        public List<string> dropDownList;
        public StackLayout info = new StackLayout();

        public LeaderboardPage()
        {
            Button sub = new Button
            {
                Text = "View Classes"
            };
            sub.Clicked += SubOnClicked;

            info.Children.Add(abc);
            info.Children.Add(sub);
            Content = info;
        }

        public async void SubOnClicked(object Sender, EventArgs args)
        {
            dropDownList = await Connection.getClassrooms();
            foreach (var o in dropDownList)
            {
                Button className = new Button
                {
                    Text = o
                };
                className.Clicked += OnNameClicked;
                info.Children.Add(className);
            }
        }
        public async void OnNameClicked(object Sender, EventArgs args)
        {
            List<Objects.Child> childrenInClass;
            childrenInClass = await Connection.GetChildren("Blue Class");
        }
    }
}