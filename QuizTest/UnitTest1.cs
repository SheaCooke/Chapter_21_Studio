using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quizzes;

namespace QuizTest
{
    [TestClass]
    public class CheckValidationMethods
    {
        [TestMethod]
        public void TrueFalseAnswerValidationCatchesTypo()
        {
            TrueFalse test = new TrueFalse("test question", "tru");
            Assert.IsFalse(test.ValidateCorrectAnswer());
        }

        [TestMethod]
        public void CheckBoxCatchesRepeatingCharacters()
        {
            CheckBox test2 = new CheckBox("test question", "A BB");
            Assert.IsFalse(test2.ValidateCorrectAnswer());
        }

        [TestMethod]
        public void MultiChoiceOnlyTakesOneAnswer()
        {
            MultiChoice test3 = new MultiChoice("test question", "A B");
            Assert.IsFalse(test3.ValidateCorrectAnswer());
        }
    }
}
