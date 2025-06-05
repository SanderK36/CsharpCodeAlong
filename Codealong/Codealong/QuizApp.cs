using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    internal class QuizApp
    {
        public List<Question> QuestionList = new List<Question>
        {
            new Question("Hva er 2+2", "4", "3", "2"),
            new Question("Hilken by er norsk?", "Oslo", "Ohio", "Omaha"),
            new Question("Hilken farge er ikke i den norske flagget?", "Grønn", "Rød", "Blå"),
        };
        public void Run()
        {
            int points = 0;
            foreach (var question in QuestionList)
            {
                while (true)
                {
                    Console.WriteLine($"Du har {points} poeng!");
                    Console.WriteLine(question.QuizQuestion);
                    Console.WriteLine($"A: {question.Answers[0]}");
                    Console.WriteLine($"B: {question.Answers[1]}");
                    Console.WriteLine($"C: {question.Answers[2]}");
                    Console.Write("Skriv ditt svar: ");
                    if (Console.ReadLine()?.ToUpper() == "A")
                    {
                        Console.Clear();
                        points++;
                        Console.WriteLine($"Riktig! du fikk ett poeng!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Feil, prøv igjen.");
                    }
                }
            }
        }
    }
}
