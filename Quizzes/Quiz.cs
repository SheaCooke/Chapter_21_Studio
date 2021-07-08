using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    public static class Quiz
    {
        public static Dictionary<string, string> QuestionsAndAnswers = new Dictionary<string, string>();

        public static int NumQuestions;

        public static int NumCorrect;

        public static string Input;

        public static void AddQuestions(Question q) // Call on an instance of a checkbox, true/false or multichoice question to add the text portion to the list 
        {
            QuestionsAndAnswers[q.CorrectAnswerTxt] = q.QuestionText;

        }

        public static void RunQuiz() // presents the questions to the user and returns a grade
        {
            NumQuestions = QuestionsAndAnswers.Count;
            NumCorrect = 0;

            foreach (var i in QuestionsAndAnswers)
            {
                Console.WriteLine(i.Value);
                Input = Console.ReadLine();

                if (i.Key == Input)
                {
                    NumCorrect++;
                }

            }

            Console.WriteLine($"Your grade is { (NumCorrect / NumQuestions) * 100}%");
            
        }


    }
}
