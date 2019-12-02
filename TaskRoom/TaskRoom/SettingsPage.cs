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
            StackLayout SettingsContent = new StackLayout();
            StackLayout Interactables = new StackLayout();
            List<Button> buttons;
            List<Label> Labels;

            Grid FontSizes = new Grid();
            FontSizes.RowDefinitions.add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            FontSizes.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Label GenericText = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.DarkGray,
            };

            Button GenericButton = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(button)),
                HorizontalOptions = LayoutOptions.centre,
            };

            Button SizeButton = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(button)),
                BackgroundColor = Color.Cornsilk,
            };

            Button ChangeProfile, ClassInformation;
            ChangeProfile = ClassInformation = GenericButton;
            ChangeProfile.Text = "Change Profile Information";
            ClassInformation.Text = "View Class Information";

            Label WelcomeMessage, FontChange;
            WelcomeMessage = FontChange = GenericText;
            WelcomeMessage.Text = "Settings";
            FontChange.Text = "FontSize";

            Button Small, Medium, Large;
            Small = Medium = Large = SizeButton;
            Small.Text = "Small";
            Medium.Text = "Medium";
            Large.Text = "Large";
            
            buttons = {  ChangeProfile, ClassInformation };



		}
	}
}