using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TaskRoom.Pages;
using TaskRoom.Objects;

namespace TaskRoom
{
    public partial class MainPage : ContentPage
    {
        public static Frame container = new Frame
        {
            BorderColor = Color.White,
            BackgroundColor = Color.FromRgb(204, 230, 255),
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.StartAndExpand
        };

        public GlobalSettings settings = new GlobalSettings();

        public MainPage()
        {
            StackLayout MainStack = new StackLayout();
            StackLayout StackA = new StackLayout();

            Padding = new Thickness(30);

            //Elements in the stack
            /////////////////////////////////////////////////////////////////////////
            Button Settings = new Button
            {
                Text = "Settings",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Button Leaderboards = new Button
            {
                Text = "Leaderboards",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 1.4,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            Leaderboards.Clicked += OnLeaderboardsClicked;

            Button Tasks = new Button
            {
                Text = "Tasks",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Button Login = new Button
            {
                Text = "Login",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.End
            };
            Login.Clicked += OnLoginClicked;

            Label Welcome = new Label
            {
                Text = "Welcome To task Room!!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Start,
            };

            var Buttons = new List<Button> { Tasks, Leaderboards, Settings, Login };
            ///////////////////////////////////////////////////////////////////////////

            StackA.Children.Add(Welcome);
            foreach (Button Butt in Buttons)
            {
                StackA.Children.Add(Butt);
            };

            container.Content = StackA;
            MainStack.Children.Add(container);

            Content = MainStack;

            //InitializeComponent();

            //Function Initisalisers

            Settings.Clicked += OnSettingsClicked;
            Tasks.Clicked += OnTasksClicked;


            //###
        }

        public void OnSettingsClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SettingsPage());
        }
        public void OnTasksClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TaskPage());
        }

        public void OnLeaderboardsClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LeaderboardPage());
        }

        public void OnLoginClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }

}
