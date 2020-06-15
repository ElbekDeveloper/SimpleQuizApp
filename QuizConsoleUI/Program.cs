using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            

            // Type your code below
            //question
            string[] questions =
            {
        "Sample Question 1",
        "Sample Question 2",
        "Sample Question 3",
        "Sample Question 4",
        "Sample Question 5"
      };
            //answers
            bool[] answers =
            {
        true,
        false,
        true,
        false,
        true,
      };
            //responses 
            bool[] responses = new bool[questions.Length];
            int score = 0;

            //check if programmer wrote correct answers
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Oops! Answers are wrongly stored in this software...");
            }
            else
            {
                int askingIndex = 0;
                foreach (string question in questions)
                {
                    bool isBool = false;
                    bool inputBool;
                    Console.WriteLine(question);
                    Console.WriteLine("True or False?");


                    string input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                    while (isBool == false)
                    {
                        Console.WriteLine("Please insert true or false...");
                        input = Console.ReadLine();
                        isBool = Boolean.TryParse(input, out inputBool);
                    }

                    responses[askingIndex] = Convert.ToBoolean(input.ToLower());
                    if (responses[askingIndex] == answers[askingIndex])
                    {
                        score++;
                    }


                    askingIndex++;



                }
                Console.WriteLine($"You got {score} out of {questions.Length}");



            }




            Console.ReadKey();

        }
    }
}
