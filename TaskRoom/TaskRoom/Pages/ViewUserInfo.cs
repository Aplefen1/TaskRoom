using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Objects;
using TaskRoom.Methods;
using TaskRoom.Pages;

namespace TaskRoom.Pages
{
    public class ViewUserInfo : ContentPage
    {
        public StackLayout infoStack = new StackLayout();
        public  Webservice webservice = new Webservice();

        public ViewUserInfo()
        {
            

            if (GlobalVariables.username == "Guest")
            {
                Label message = new Label
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Text = "You are logged in as guest"
                };
                infoStack.Children.Add(message);
            }
            else
            {
                SetContent();
            }
            Content = infoStack;
        }

        public async void SetContent()
        {
            JsonChild child = await webservice.GetChildData();
            
            Label name = new Label
            {
                Text = child.firstname
            };
            Label lastName = new Label
            {
                Text = child.lastname
            };
            Label username = new Label
            {
                Text = child.username
            };
            Label age = new Label
            {
                Text = child.age.ToString()
            };
            Label points = new Label
            {
                Text = child.points.ToString()
            };
            infoStack.Children.Add(name);
            infoStack.Children.Add(lastName);
            infoStack.Children.Add(username);
            infoStack.Children.Add(age);
            infoStack.Children.Add(points);

        }

    }
}