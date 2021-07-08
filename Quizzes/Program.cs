using System;

namespace Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Question test = new Question();

            TrueFalse test2 = new TrueFalse("test question", "true");

            test2.AddQuestions();

            test2.RunQuiz();*/

            MultiChoice test = new MultiChoice("What is the capital of Texas:\nA-Austin\nB-Seattle", "A");

            TrueFalse test2 = new TrueFalse("True or false. Today is Thursday", "True");

            CheckBox test3 = new CheckBox("Which of the following states are on the East Coast? \nA-New York\nB-Main\nC-California", "A B");

            //Console.WriteLine(test.CorrectAnswerTxt);

            Quiz.AddQuestions(test);

            Quiz.AddQuestions(test2);

            Quiz.AddQuestions(test3);

            Quiz.RunQuiz();

            /*
            Console.WriteLine(test.ValidateCorrectAnswer());
            Console.WriteLine(test2.ValidateCorrectAnswer());
            Console.WriteLine(test3.ValidateCorrectAnswer());
            */










        }
    }
}
