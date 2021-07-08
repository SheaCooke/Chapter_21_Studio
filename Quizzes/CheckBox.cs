using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    public class CheckBox : Question
    {

        /*

        public CheckBox(string txt, string correctAnswer)
        {
            QuestionText = txt;
            CorrectAnswerTxt = correctAnswer;
        }*/

        public CheckBox(string txt, string answer) : base(txt, answer) 
        {

        }

        public bool ValidateCorrectAnswer() // makes sure there are no repeating chars 
        {
            for (int i = 0; i < this.CorrectAnswerTxt.Length - 1; i++)
            {
                if (this.CorrectAnswerTxt[i] == this.CorrectAnswerTxt[i + 1])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
