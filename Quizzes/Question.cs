using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    public class Question 
    {

        public string QuestionText { get; set; }

        public string CorrectAnswerTxt { get; set; }

        public Question(string questiontxt, string correctAnswer)
        {
            QuestionText = questiontxt;
            CorrectAnswerTxt = correctAnswer;
        }



        

        


    }
}
