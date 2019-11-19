using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskRoom
{

    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            //List<string> Buttons = new List<string>;
            //Buttons = ["Play Game", "Leaderboards", "Settings", "Login"]

            Padding = new Thickness(30);
            

            Content = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                //VerticalOptions = LayoutOptions.StartAndExpand,

                Content = new StackLayout
                {
                    Children = {
                        new Label
                        {
                            Text = "Welcome To task Room!!",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            VerticalOptions = LayoutOptions.Start,
                        },
                        new Button
                        {
                            Text = "Tasks",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                        },
                        new Button
                        {
                            Text = "Leaderboards",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) *1.4,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                        },
                        new Button
                        {
                            Text = "Settings",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            VerticalOptions = LayoutOptions.End,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                        },
                        new Button
                        {
                            Text = "Login",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            VerticalOptions = LayoutOptions.End,
                            HorizontalOptions = LayoutOptions.End
                        },
                    }
                }
            };
        }
    }
}
