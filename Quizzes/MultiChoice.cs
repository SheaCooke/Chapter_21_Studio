using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class MultiChoice : Question
    {

        /*
        public MultiChoice(string txt, string correctAnswer)
        {
            QuestionText = txt;
            CorrectAnswerTxt = correctAnswer;
        }*/

        public MultiChoice(string txt, string answer) : base(txt, answer)
        {

        }

        public bool ValidateCorrectAnswer()
        {
            if (this.CorrectAnswerTxt.Length == 1)
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
