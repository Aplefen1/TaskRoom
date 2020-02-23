using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TaskRoom.Test
{
    public class Question : ContentPage
    {
        public Question(ref bool correct)
        {
            ///////////////////////////////////////////////////////// 
            Label equation = new Label {};
            Entry answer = new Entry
            {
                Placeholder = "Your Answer Here"
            };
            Button submitAnswer = new Button {
                Text = "Submit"
            };
            submitAnswer.Clicked += OnSubmitAnswerClicked();
    
            int numberOne = Number();
            int numberTwo = Number();
            int correctAnswer = CalculateAnswer(numberOne, numberTwo);

            equation.Text = numberOne.ToString() + " + " + numberTwo.ToString();
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

        public void OnSubmitAnswerClicked(object Sender, EventArgs args, ref bool correct)
        {

        }
    }
}