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
            //put out 4 mutltipul choice answers
            List<string> answers = new List<string>();
            answers.Add("1");
            answers.Add("many");
            answers.Add("zero");
            answers.Add("fivehundred");

            int correctAnswerNumber = 0; //next, fix this

            for (int questionNumber = 0; questionNumber < numberOfQuestions; questionNumber++)
            {
                string question = questions[questionNumber];
                Console.WriteLine(answers);
                Console.WriteLine(question);
            foreach (string answer in answers)
            {
                Console.WriteLine(answer);
            }
            string userinput = Console.ReadLine();
            if (userinput == answers[correctAnswerNumber])
                Console.WriteLine("yay");
            else
                Console.WriteLine("bummer");
            } 

        }
    }
}
