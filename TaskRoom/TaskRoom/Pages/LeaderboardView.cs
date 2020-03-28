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
        //Takes in a list of children objects
        //consists of name and points
        public LeaderboardView(List<Objects.Child> children)
        {
            //orders the children by points and creates a new list that is ordered
            List<Objects.Child> orderedChildren = children.OrderBy(a => a.points).ToList();

            StackLayout contentStack = new StackLayout();

            //iterates through each child in the ordered list
            foreach (Objects.Child c in orderedChildren)
            {
                //creates a horizontal stack to display the name and points aesthetically
                StackLayout childView = new StackLayout() { Orientation = StackOrientation.Horizontal };

                //label with child's name
                Label childName = new Label
                {
                    Text = c.name
                };

                //label with child's points
                Label points = new Label
                {
                    Text = c.name.ToString()
                };
                //adds lables to horizontal stack layout 

                childView.Children.Add(childName);
                childView.Children.Add(points);

                //adds horizontal stack layout to the page's stack layout
                contentStack.Children.Add(childView);
            }
            //sets the content of the page to the page's stack layout
            Content = contentStack;
        }
    }
}