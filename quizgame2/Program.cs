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
            question = "how old is oprah";
            Console.Write(question);

            //put out 4 mutltipul choice answers
            List<string> answers = new List<string>();
            answers.Add("fifty");
            answers.Add("twenty");
            answers.Add("thirtythree");
            answers.Add("eighty");

            //read user input
            Console.ReadLine();
            string userinput = Console.ReadLine();

            //compair user intput to answers
            if (userinput == "twenty")
                Console.WriteLine("yay");
            else
                Console.WriteLine("bummer");



            //win or lose?

        }
    }
}
