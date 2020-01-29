using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Methods;

namespace TaskRoom.Pages
{
    public class CreateUser : ContentPage
    {
        public Entry Name, LName, UName, PWord, Age;
        public Webservice Connection = new Webservice();

        public CreateUser()
        {
            StackLayout entryStack = new StackLayout();
            StackLayout contentStack = new StackLayout();
            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            var entry = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };

            var Submit = new Button
            {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };
            Submit.Clicked += OnSubmit;


            
            Name = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
            LName = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
            UName = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
            PWord = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };
            Age = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };

            Name.Placeholder = "Name";
            LName.Placeholder = "Last Name";
            UName.Placeholder = "Username";
            PWord.Placeholder = "Password";
            Age.Placeholder = "Age";

            entryStack.Children.Add(Name);
            entryStack.Children.Add(LName);
            entryStack.Children.Add(UName);
            entryStack.Children.Add(PWord);
            entryStack.Children.Add(Age);
            entryStack.Children.Add(Submit);

            container.Content = entryStack;

            contentStack.Children.Add(container);

            Content = contentStack;

        }
        public void OnSubmit(object Sender, EventArgs args)
        {
            string inputtedName = Name.Text;
            string inputtedLName = LName.Text;
            string inputtedUName = UName.Text;
            string inputtedPWord = PWord.Text;
            string inputtedAge = Age.Text;

            Connection.Login(inputtedName, inputtedLName, inputtedUName, inputtedPWord, inputtedAge);

        }

    }
}