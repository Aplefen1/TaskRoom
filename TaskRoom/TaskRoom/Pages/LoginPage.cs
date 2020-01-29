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
        public Webservice webservice = new Webservice();
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

            var Submit = new Button
            {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            var newUser = new Button
            {
                Text = "New User",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };
            newUser.Clicked += OnNewUserClicked;
            Submit.Clicked += OnSubmit;

            Entry UName = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
            Entry PWord = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };

            UName.Placeholder = "Username";
            PWord.Placeholder = "Password";

            contentStack.Children.Add(UName);
            contentStack.Children.Add(PWord);
            contentStack.Children.Add(Submit);
            contentStack.Children.Add(newUser);

            container.Content = contentStack;

            contentStack.Children.Add(container);

            Content = contentStack;
        }

        public void OnNewUserClicked(object Sender, EventArgs args)
        {
            Navigation.PushAsync(new CreateUser());
        }

        public void OnSubmit(object Sender, EventArgs args)
        {
            webservice
        }

    }
}