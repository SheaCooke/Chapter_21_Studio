using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    public class Quiz
    {

        public List<string> QuestionList { get; set; }
        public double Grade { get; set; }

        public void AddQuestions() // Call on an instance of a checkbox, true/false or multichoice question to add the text portion to the list 
        {

        }

        public string RunQuiz() // presents the questions to the user and returns a grade
        {

            return $"Your grade is {this.Grade}%";
        }


    }
}
