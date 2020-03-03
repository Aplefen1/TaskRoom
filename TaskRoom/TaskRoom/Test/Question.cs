using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Diagnostics;

namespace TaskRoom.Test
{
    public class Question : ContentPage
    {
        //grid initialiser
        public Grid questions = new Grid();
        public Random r = new Random();
        public int[] answerList;

        public Question(int noQuestions)
        {
            //Defines the properties of the questions grid
            ColumnDefinition numColumn = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition eq = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition ent = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            questions.ColumnDefinitions.Add(numColumn);
            questions.ColumnDefinitions.Add(eq);
            questions.ColumnDefinitions.Add(ent);

            //A list of all the answers to the questions, the index will be the question number
            answerList = new int[noQuestions];

            //Creates the amount of questions specified by the user
            for (int i = 0; i < noQuestions; i++)
            {
                //Makes the computer wait for a couple of milliseconds so that all the numbers arent the same
                System.Threading.Thread.Sleep(2);
                int num1 = Number();
                System.Threading.Thread.Sleep(2);
                int num2 = Number();

                //creates new elements for each row of the question grid
                Label qNum = new Label
                {
                    Text = (i + 1).ToString()
                };
                Label equation = new Label {
                    Text = num1.ToString() + " + " + num2.ToString(),
                };
                Entry ans = new Entry
                {
                    Placeholder = "Answer",
                };

                //calculates the answer (add other operators)
                answerList[i] = CalculateAnswer(num1, num2);

                //creates a new row and adds the elements to that row
                questions.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                questions.Children.Add(qNum, 0, i);
                questions.Children.Add(equation, 1, i);
                questions.Children.Add(ans, 2, i);
            }

            Button submit = new Button
            {
                Text = "Submit answers"
            };
            submit.Clicked += OnSubmit;
            questions.Children.Add(submit, 1, noQuestions);

            //Creates the stacklayout that holds the grid
            StackLayout questionStack = new StackLayout();
            //creates a scrollview that holds the stacklayoput above
            //this allows the questions to be scrolled through on the application
            ScrollView scrollableQuestions = new ScrollView();
            questionStack.Children.Add(questions);
            scrollableQuestions.Content = questionStack;
            Content = scrollableQuestions;

        }

        //new random number
        public int Number()
        {
            System.Threading.Thread.Sleep(2);
            return r.Next(1, 30);
        }

        //calculates answer for question
        public int CalculateAnswer(int numa, int numb)
        {
            return numa + numb;
        }

        public void OnSubmit(object Sender, EventArgs args)
        {
            //creates a lis of entry objects
            List<Entry> userAnswers = new List<Entry>();

            //adds all the enntry objects from the gid (They contain the user's answers)
            foreach (var elem in questions.Children)
            {
                if (elem.GetType() == typeof (Entry)){
                    userAnswers.Add(elem as Entry);
                }
                else
                {
                    Debug.WriteLine(elem);
                }
            }
            //enumerate through the users answers
            int i = 0;
            foreach (int ans in answerList)
            {
                int currentAns = 0;
                bool valid = true;

                //attempts to change the user's answer into an int so it can be operated on
                try {
                    currentAns = Int32.Parse(userAnswers[i].Text);
                }
                catch
                {
                    valid = false;
                    userAnswers[i].Text = "Invalid";
                }
                
                //highlights which answers are right as Green and invalid and wrong answers as Red
                if (ans == currentAns && valid == true)
                {
                    userAnswers[i].BackgroundColor = Color.Green;
                }
                else
                {
                    userAnswers[i].BackgroundColor = Color.Red;
                }
                i++;
            }
        }
    }
}