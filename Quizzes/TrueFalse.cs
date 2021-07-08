using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes 
{
    public class TrueFalse : Question
    {

        /*
        public TrueFalse(string txt, string correctAnswer)
        {
            QuestionText = txt;
            CorrectAnswerTxt = correctAnswer;
        }
        */

        public TrueFalse(string txt, string answer) : base(txt, answer)
        {

        }

        public bool ValidateCorrectAnswer() // makes sure every answer is either true or false 
        {
            if (this.CorrectAnswerTxt.ToLower() == "true" || this.CorrectAnswerTxt.ToLower() == "false")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
