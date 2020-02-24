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
        public List<ColumnDefinition> columns = new List<ColumnDefinition>();
        public Question(int noQuestions)
        {
            ColumnDefinition numColumn = new ColumnDefinition { Width = GridLength.Auto };
            ColumnDefinition eq = new ColumnDefinition { Width = GridLength.Auto };
            ColumnDefinition ent = new ColumnDefinition { Width = GridLength.Auto };
            questions.

            for (int i = 0; i < noQuestions; i++)
            {
                int num1 = Number();
                int num2 = Number();
                Label qNum = new Label
                {
                    Text = i.ToString()
                };
                Label equation = new Label {
                    Text = num1.ToString() + " + " + num2.ToString(),
                };
                Entry ans = new Entry
                {
                    Placeholder = "Answer"
                };

            }
        }

        public int Number()
        {
            Random r = new Random();
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