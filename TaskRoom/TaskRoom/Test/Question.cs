using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TaskRoom.Test
{
    public class Question : ContentPage
    {
        public Entry answer = new Entry
        {
            Placeholder = "Your Answer Here"
        };

        public Grid questions = new Grid();
        public Random r = new Random();

        public Question(int noQuestions)
        {
            ColumnDefinition numColumn = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition eq = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition ent = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            questions.ColumnDefinitions.Add(numColumn);
            questions.ColumnDefinitions.Add(eq);
            questions.ColumnDefinitions.Add(ent);

            for (int i = 0; i < noQuestions; i++)
            {
                System.Threading.Thread.Sleep(2);
                int num1 = Number();
                System.Threading.Thread.Sleep(2);
                int num2 = Number();
                Label qNum = new Label
                {
                    Text = (i + 1).ToString()
                };
                Label equation = new Label {
                    Text = num1.ToString() + " + " + num2.ToString(),
                };
                Entry ans = new Entry
                {
                    Placeholder = "Answer"
                };
                questions.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                questions.Children.Add(qNum, 0, i);
                questions.Children.Add(equation, 1, i);
                questions.Children.Add(ans, 2, i);
            }
            StackLayout questionStack = new StackLayout();
            ScrollView scrollableQuestions = new ScrollView();
            questionStack.Children.Add(questions);
            scrollableQuestions.Content = questionStack;
            Content = scrollableQuestions;

        }

        public int Number()
        {
            System.Threading.Thread.Sleep(2);
            return r.Next(0, 20);
        }

        public int CalculateAnswer(int numa, int numb)
        {
            return numa + numb;
        }

        public void OnSubmitAnswerClicked(object Sender, EventArgs args)
        {

        }
    }
}