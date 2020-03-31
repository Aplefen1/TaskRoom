using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Pages;
using TaskRoom.Objects;
using TaskRoom.Test;
using TaskRoom.Methods;

namespace TaskRoom
{
    public class TaskPage : ContentPage
    {
        public Webservice connection = new Webservice();

        public Label Status = new Label
        {
            Text = "You Are logged in as: " + GlobalVariables.username,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            HorizontalOptions = LayoutOptions.Center
        };

        public TaskPage()
        {
            //creates the two stacklayouts for the page
            StackLayout TaskContent = new StackLayout() {
                Spacing = 20};
            StackLayout PageContent = new StackLayout();

            Padding = new Thickness(30);

            //creates the grid for the settings page


            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };
            Label Welcome = new Label
            {
                Text = "TASK HUB",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            Button TeacherTasks = new Button
            {
                Text = "View Teacher Tasks",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center
            };
            TeacherTasks.Clicked += ViewTask;

            Button Test = new Button
            {
                Text = "Start a Test",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center
            };
            Test.Clicked += TestPageOpen;

            TaskContent.Children.Add(Welcome);
            TaskContent.Children.Add(TeacherTasks);
            TaskContent.Children.Add(Test);
            TaskContent.Children.Add(Status);


            container.Content = TaskContent;
            PageContent.Children.Add(container);
            Content = PageContent;

        }

        public void TestPageOpen(object sender, EventArgs args)
        {
            //pushes Test Page
            Navigation.PushAsync(new TestPage());
        }

        public async void ViewTask(object sender, EventArgs args)
        {
            if (GlobalVariables.username != "Guest")
            {
                try {

                    JsonTask ReturnedTask = await connection.GetTaskData();

                    if (ReturnedTask.dueDate == "NA")
                    {
                        Status.Text = "No set Task";

                    }

                    else
                    {
                        Navigation.PushAsync(new ViewTask(ReturnedTask));
                    };

                }

                catch { Status.Text = "No set Task"; };

                
            }
        }

    }
}