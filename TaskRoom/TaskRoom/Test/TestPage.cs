﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TaskRoom.Test
{
    public class TestPage : ContentPage
    {
        public Entry numberOfQuestions = new Entry
        {
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.Start,
            Placeholder = "Number Of Questions"
        };

        public TestPage()
        {
            Button createTest = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Text = "Create Test"
            };
            createTest.Clicked += CreateTestOnClicked;
        }

        public void CreateTestOnClicked(object sender, EventArgs args)
        {
            int questions;
            bool valid = true;
            try
            {
                questions = int.Parse(numberOfQuestions.Text);
            }
            catch
            {
                numberOfQuestions.Text = "Invalid input";
                valid = false;
            }
            if (valid == true)
            {

            }

        }



    }
}