using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;
using TaskRoom.Methods;
using TaskRoom.Objects;
using TaskRoom.Pages;

namespace TaskRoom
{
    public class LeaderboardPage : ContentPage
    {
        public Webservice Connection = new Webservice();
        public Label abc = new Label { Text = "TEst" };
        //Global dropdown list to store classroom names
        public List<string> dropDownList;
        public StackLayout info = new StackLayout();

        public LeaderboardPage()
        {
            //Makes a button for the user to interact with
            Button sub = new Button
            {
                Text = "View Classes"
            };
            sub.Clicked += SubOnClicked;

            //adds the button to the stack
            info.Children.Add(sub);
            //sets the stack to be the page's content
            Content = info;
        }

        public async void SubOnClicked(object Sender, EventArgs args)
        {
            //calls the Get Classrooms Function to get a list of all the classrooms
            dropDownList = await Connection.GetClassrooms();
            //iterates through the list
            foreach (var o in dropDownList)
            {
                //creates a new button for each item in the list
                Button className = new Button
                {
                    Text = o
                };
                //adds the same function to each button
                className.Clicked += OnNameClicked;
                //adds the button to the global stack
                info.Children.Add(className);
            }
        }
        public async void OnNameClicked(object Sender, EventArgs args)
        {
            List<Objects.Child> childrenInClass;
            //gets a list of all the children in the button's class using the name of the class
            childrenInClass = await Connection.GetChildren("Blue Class");
            //calls the Leaderboard View page withj the children as a list as the argument
            await Navigation.PushAsync(new LeaderboardView(childrenInClass));
        }
    }
}