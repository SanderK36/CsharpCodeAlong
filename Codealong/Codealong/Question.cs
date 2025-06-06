using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    internal class Question
    {
        public string QuizQuestion {  get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string question, string[] answers, int correctAnswer = 0)
        {
            QuizQuestion = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
