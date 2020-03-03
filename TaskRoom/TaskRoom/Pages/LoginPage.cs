using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Methods;

namespace TaskRoom.Pages
{
    public class LoginPage : ContentPage
    {

        //The fields where the user inputs their login data
        public Entry UName = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
        public Entry PWord = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
        //Creation of the Webervice class to be used for the login function
        public static Webservice webservice = new Webservice();
        public Label status = new Label
        {
            Text = webservice.status
        };

        public LoginPage()
        {
            StackLayout detailsStack = new StackLayout();
            StackLayout contentStack = new StackLayout();

            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            //Button that runs the function that submits the info
            var Submit = new Button
            {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };
            //Goes to the create user page
            var newUser = new Button
            {
                Text = "New User",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            //label that shows the output of the login function for debugging

            newUser.Clicked += OnNewUserClicked;
            Submit.Clicked += OnSubmit;
       
            UName.Placeholder = "Username";
            PWord.Placeholder = "Password";
            //Adding the Elements to the stack
            detailsStack.Children.Add(UName);
            detailsStack.Children.Add(PWord);
            detailsStack.Children.Add(Submit);
            detailsStack.Children.Add(newUser);
            detailsStack.Children.Add(status);

            container.Content = detailsStack;

            contentStack.Children.Add(container);

            Content = contentStack;
        }

        public void OnNewUserClicked(object Sender, EventArgs args)
        {
            Navigation.PushAsync(new CreateUser());
        }
        //Function thats called when submit is pressed
        public async void OnSubmit(object Sender, EventArgs args)
        {
            string a = UName.Text;
            string b = PWord.Text;
            string loginStatus = await webservice.checkUser(a, b);
            if (loginStatus == "Failed Login")
            {
                status.Text = "LoginFailed";
            }
            else
            {
                status.Text = "Success!";
                Navigation.PopAsync();
                Navigation.PopAsync();
                Navigation.PushAsync(new MainPage());
            }
            
        }

    }
}