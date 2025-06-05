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
            new Question("Hva er 2+2", new[]{"4", "3", "2"}, 0),
            new Question("Hilken by er norsk?", new[] { "Ohio", "Oslo", "Omaha" }, 1),
            new Question("Hilken farge er ikke i den norske flagget?", new[] { "Blå", "Rød", "Grønn" }, 2),
        };
        public void Run()
        {
            int points = 0;
            foreach (var question in QuestionList.ToList())
            {
                    Console.WriteLine($"Du har {points} poeng!");
                    Console.WriteLine(question.QuizQuestion);
                    Console.WriteLine($"A: {question.Answers[0]}");
                    Console.WriteLine($"B: {question.Answers[1]}");
                    Console.WriteLine($"C: {question.Answers[2]}");
                    Console.Write("Skriv ditt svar: ");
                    string input = Console.ReadLine()?.ToUpper();
                    if (input == "A" && question.CorrectAnswer == 0 ||
                        input == "B" && question.CorrectAnswer == 1 ||
                        input == "C" && question.CorrectAnswer == 2)
                    {
                        Console.Clear();
                        points++;
                        Console.WriteLine($"Riktig! du fikk ett poeng!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Feil, prøv igjen.");
                        QuestionList.Add(question);
                        Console.ReadKey();
                        Console.Clear();
                    }
            }
            Console.WriteLine($"Quiz ferdig! du fikk {points} poeng av {QuestionList.Count}");
            Console.WriteLine("Vil du spille igjen? (J/N)");
            if (Console.ReadLine()?.ToUpper() == "J")
            {
                Console.Clear();
                Run();
            }
        }
    }
}
