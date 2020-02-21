using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Pages;

namespace TaskRoom
{
    public class TaskPage : ContentPage
    {
        public TaskPage()
        {
            StackLayout TaskContent = new StackLayout() {
                Spacing = 20};
            StackLayout PageContent = new StackLayout();

            Padding = new Thickness(30);

            //
            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });

            var frogLeap = new Button { Text = "Frog Leap" };
            var spelling = new Button { Text = "Spelling Game" };
            var test = new Button { Text = "Test" };
            test

            grid.Children.Add(frogLeap, 0, 0);
            grid.Children.Add(spelling, 1, 0);
            grid.Children.Add(test, 0, 1);
            //

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

            TaskContent.Children.Add(Welcome);
            TaskContent.Children.Add(TeacherTasks);
            TaskContent.Children.Add(grid);
            container.Content = TaskContent;
            PageContent.Children.Add(container);
            Content = PageContent;

        }
    }
}