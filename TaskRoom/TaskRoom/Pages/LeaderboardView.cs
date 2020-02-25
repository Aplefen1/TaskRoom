using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TaskRoom.Objects;

namespace TaskRoom.Pages
{
    public class LeaderboardView : ContentPage
    {
        public LeaderboardView(List<Objects.Child> children)
        {
            List<Objects.Child> orderedChildren = children.OrderBy(a => a.points).ToList();
            StackLayout contentStack = new StackLayout();

            foreach (Objects.Child c in orderedChildren)
            {
                StackLayout childView = new StackLayout() { Orientation = StackOrientation.Horizontal };
                Label childName = new Label
                {
                    Text = c.name
                };
                Label points = new Label
                {
                    Text = c.name.ToString()
                };
                childView.Children.Add(childName);
                childView.Children.Add(points);
                contentStack.Children.Add(childView);
            }

            Content = contentStack;
        }
    }
}