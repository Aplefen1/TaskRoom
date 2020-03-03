using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Pages;

namespace TaskRoom
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
            //Here I'm declaring all the variables that i will use throughout the method
            StackLayout SettingsContent = new StackLayout();
            StackLayout Interactables = new StackLayout();
            

            //This creates a Grid object wich is native to xamarin, it creates a grid that is 1 tall by three wide
            var FontSizes = new Grid() { ColumnSpacing = 5 };
            FontSizes.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });

            //This frame is used to present the data in an aesthetically pleasing and continious matter
            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            //I create generic label and button objects that I will use later

            //This defines the content of the page by inheriting from the generic models above
            Button ChangeProfile = new Button
            {
                Text = "Change Profile Information",
            };
            ChangeProfile.Clicked += OnChangeProfileClicked;
            Button ClassInformation = new Button
            {
                Text = "View Class Information",
            };

            Label WelcomeMessage = new Label
            {
                Text = "Settings",
            };
            Label FontChange = new Label
            {
                Text = "FontSize"
            };

            Button Small = new Button
            {
                Text = "Small"
            };
            Button Medium = new Button
            {
                Text = "Medium"
            };
            Button Large = new Button()
            {
                Text = "Large"
            };

            //This populates the grid FontSizes grid I created at the beginning of the method
            FontSizes.Children.Add(Small, 0, 0);
            FontSizes.Children.Add(Medium, 1, 0);
            FontSizes.Children.Add(Large, 2, 0);

            FontSizes.HorizontalOptions = LayoutOptions.Start;

            //Maybe put the grid within another container??
            Interactables.Children.Add(WelcomeMessage);
            Interactables.Children.Add(FontChange);
            Interactables.Children.Add(FontSizes);
            Interactables.Children.Add(ChangeProfile);
            Interactables.Children.Add(ClassInformation);

            SettingsContent.Children.Add(container);
            Content = Interactables;
        }
        public void OnChangeProfileClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ViewUserInfo());
        }

    }

}