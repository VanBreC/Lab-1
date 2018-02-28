//Brendan VandeVoorde
//Test Results


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Driver_Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Your Answers\nPress Enter After Typing Each Answer\n");
            string[] answers = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"};
            string[] questionNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
            string[] userAnswerlist = new string[20];
            int Score = 20;
            for (int i = 0; i < answers.Length; i++)
            {
                
                userAnswerlist[i] = Console.ReadLine().ToUpper();
                if (answers[i] != userAnswerlist[i])
                    Score = Score - 1;
               
            }

            Console.WriteLine(" ");
            Console.WriteLine(Score);
            if (Score > 15)
                Console.WriteLine("YOU PASS!!!\n");
            else
                Console.WriteLine("Test Failed\nBetter Luck Next Time!\n");
            Console.WriteLine("Question Numbers");
            Console.WriteLine(string.Join(", ",questionNumber));
            Console.WriteLine("======================================================================");
            Console.WriteLine("Test Answers");
            Console.WriteLine(string.Join(", ",answers));
            Console.WriteLine("======================================================================");
            Console.WriteLine("Your Answers");
            Console.WriteLine(string.Join(", ",userAnswerlist));
            Console.WriteLine("======================================================================");
            Console.ReadLine();
        }
    }
}
