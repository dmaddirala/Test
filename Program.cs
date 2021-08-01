using System;
using System.Collections.Generic;

namespace QnA
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            var questions = repository.GetQuestions();

            Console.WriteLine();

            foreach(var question in questions){
                Console.WriteLine( (questions.IndexOf(question)+1) + ")");
                Console.WriteLine("Title: " + question.Title);
                Console.WriteLine("username: " + question.UserName);
                Console.WriteLine("Email Id: " + question.UserEmailId);
                Console.WriteLine("Time: " + question.UpdateDate.Date);
                Console.WriteLine("------------------------------------------------\n");
            }
        }
    }
}
