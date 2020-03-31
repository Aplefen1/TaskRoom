using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Objects;

namespace TaskRoom.Pages
{
    public class ViewTask : ContentPage
    {
        public ViewTask(JsonTask Task)
        {

            StackLayout stack = new StackLayout();
            StackLayout stacka = new StackLayout();

            Frame container = new Frame
            {
                BorderColor = Color.White,
                BackgroundColor = Color.FromRgb(204, 230, 255),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            Label Name = new Label
            {
                Text = Task.taskName,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            Label Description = new Label
            {
                Text = Task.taskDescription,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            Label Due = new Label
            {
                Text = Task.dueDate,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            stack.Children.Add(Name);
            stack.Children.Add(Description);
            stack.Children.Add(Due);

            container.Content = stack;

            stacka.Children.Add(container);

            Content = stacka;
        }
    }
}