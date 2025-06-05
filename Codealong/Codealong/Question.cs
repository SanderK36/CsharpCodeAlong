using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    internal class Question
    {
        public string QuizQuestion {  get; private set; }
        public string[] Answers { get; private set; }
        public int CorrectAnswer { get; private set; }

        public Question(string question, string[] answers, int correctAnswer = 0)
        {
            QuizQuestion = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
