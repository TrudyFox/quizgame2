using System;
using System.Collections.Generic;

namespace quizgame2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask question
            List<string> questions = new List<string>();
            questions.Add("How many children does Oprah have?");
            questions.Add("How many houses does Oprah own?");
            questions.Add("Am I doning this correct?");
            questions.Add("how many dogs does oprah have?");
            Int32 numberOfQuestions = questions.Count;

            for (int questionNumber = 0; questionNumber < numberOfQuestions; questionNumber++)
            {
                string question = questions[questionNumber];
            } 

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
