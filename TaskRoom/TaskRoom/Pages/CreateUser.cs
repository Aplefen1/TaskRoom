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
        //All the entrys needed
        public Entry Name, LName, UName, PWord, Age;
        public Webservice Connection = new Webservice();
        //Label to display message from webservice
        public Label sendStatus = new Label
        {
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.StartAndExpand
        };


        public CreateUser()
        {
            StackLayout entryStack = new StackLayout();
            StackLayout contentStack = new StackLayout();
            //frame to contain entries
            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            var entry = new Entry { HorizontalOptions = LayoutOptions.CenterAndExpand };

            //Button for the user to push to submit answers
            var Submit = new Button
            {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };
            
            Submit.Clicked += OnSubmit;


            //initialising the entries
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

            //adding entries to the stack
            entryStack.Children.Add(Name);
            entryStack.Children.Add(LName);
            entryStack.Children.Add(UName);
            entryStack.Children.Add(PWord);
            entryStack.Children.Add(Age);
            entryStack.Children.Add(Submit);
            entryStack.Children.Add(sendStatus);

            container.Content = entryStack;

            contentStack.Children.Add(container);

            Content = contentStack;

        }
        public async void OnSubmit(object Sender, EventArgs args)
        {
            //Getting the inputted text from the entries
            string inputtedName = Name.Text;
            string inputtedLName = LName.Text;
            string inputtedUName = UName.Text;
            string inputtedPWord = PWord.Text;
            string inputtedAge = Age.Text;

            //Awaits for a confirmation string from the connection class
            string status = await Connection.newUser(inputtedName, inputtedLName, inputtedUName, inputtedPWord, inputtedAge);
            //removes the page from the navigation stack if it successful
            if (status == "True")
            {
                Navigation.PopAsync();
            }
            //changes the status label if it was not successful
            else
            {
                sendStatus.Text = "Something went wrong";
            }

        }

    }
}