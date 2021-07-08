using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes 
{
    class TrueFalse : Question
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
    }
}
