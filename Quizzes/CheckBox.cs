using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class CheckBox : Question
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

        public void ValidateCorrectAnswer(CheckBox q)
        {
           // int len = q.CorrectAnswerTxt.Length;

            


        }
    }
}
