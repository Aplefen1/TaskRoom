using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

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
            Label GenericText = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.DarkGray,
            };

            Button GenericButton = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
            };

            Button SizeButton = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)),
                BackgroundColor = Color.Cornsilk,
            };

            //This defines the content of the page by inheriting from the generic models above
            Button ChangeProfile, ClassInformation;
            ChangeProfile = ClassInformation = GenericButton;
            ChangeProfile.Text = "Change Profile Information";
            ClassInformation.Text = "View Class Information";

            Label WelcomeMessage, FontChange;
            WelcomeMessage = FontChange = GenericText;
            WelcomeMessage.Text = "Settings";
            FontChange.Text = "FontSize";

            Button Small, Medium, Large;
            Small = SizeButton;
            Medium = SizeButton;
            Large = SizeButton;
            Small.Text = "Small";
            Medium.Text = "Medium";
            Large.Text = "Large";

            //This populates the grid FontSizes grid I created at the beginning of the method
            FontSizes.Children.Add(Small, 0, 0);
            FontSizes.Children.Add(Medium, 1, 0);
            //FontSizes.Children.Add(Large, 2, 0);

            //buttons = { ChangeProfile, ClassInformation };
            //Labels = { WelcomeMessage, }

            FontSizes.HorizontalOptions = LayoutOptions.Start;
        
            //Maybe put the grid within another container??
            object[] Elements = new object[5] { WelcomeMessage, FontChange, FontSizes, ChangeProfile, ClassInformation };
            foreach(var elem in Elements)
            {
                if (elem.GetType() == typeof(Button))
                {
                    Interactables.Children.Add((Button)elem);
                    Console.WriteLine("Button");
                }

                else if (elem.GetType() == typeof(Label))
                {
                    Interactables.Children.Add((Label)elem);
                    Console.WriteLine("Label");
                }

                else
                {
                    Interactables.Children.Add((Grid)elem);
                };
            }
            container.Content = Interactables;
            SettingsContent.Children.Add(container);
            Content = SettingsContent;
        }
	}
}