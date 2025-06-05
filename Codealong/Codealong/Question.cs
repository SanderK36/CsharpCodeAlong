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

        public Question(string question, string correctAnswer, string answer2, string answer3)
        {
            QuizQuestion = question;
            Answers = new[] {correctAnswer, answer2, answer3};
        }
    }
}
