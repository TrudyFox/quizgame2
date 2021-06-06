using System;
using System.Collections.Generic;

namespace quizgame2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask question

            string question;
            question = "how many dogs does oprah have?";
            Console.Write(question);

            //put out 4 mutltipul choice answers
            List<string> answers = new List<string>();
            answers.Add("1");
            answers.Add("many");
            answers.Add("zero");
            answers.Add("fivehundred");

            int correctAnswerNumber = 0;



            foreach (string answer in answers)
            {
                Console.WriteLine(answer);
            }

            //read user input
            string userinput = Console.ReadLine();

            //compair user intput to answers the answer number 3 is always the correct answer
            if (userinput == answers[correctAnswerNumber])
                Console.WriteLine("yay");
            else
                Console.WriteLine("bummer");




            //win or lose?

        }
    }
}
