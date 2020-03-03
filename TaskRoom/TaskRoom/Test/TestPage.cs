using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;

namespace TaskRoom.Test
{
    public class TestPage : ContentPage
    {
        //Creates a public instance of the entry class
        public Entry numberOfQuestions = new Entry
        {
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.Start,
            Placeholder = "Number Of Questions"
        };

        public TestPage()
        {
            //Button to submit data
            Button createTest = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Text = "Create Test"
            };
            createTest.Clicked += CreateTestOnClicked;

            //adds elements to stack
            StackLayout contents = new StackLayout();
            contents.Children.Add(numberOfQuestions);
            contents.Children.Add(createTest);
            Content = contents;
        }

        public void CreateTestOnClicked(object sender, EventArgs args)
        {
            int questions = 0;
            bool valid = true;
            //trys to parse the inputted number of questions into an int
            try
            {
                questions = int.Parse(numberOfQuestions.Text);
            }
            //if it cant then the entry box show invalid input
            catch
            {
                numberOfQuestions.Text = "Invalid input";
                valid = false;
            }
            //creates a question page that passes the amount of questions needed.
            if (valid == true)
            {
                Navigation.PushAsync(new Question(questions));
            }

        }
        


    }
}