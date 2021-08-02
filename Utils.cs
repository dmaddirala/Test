using System;
using System.Collections.Generic;

namespace QnA
{
    class Utils
    {
        public static List<Question> GenerateQuestions(){
            var Questions = new List<Question>() ;
            Questions.Add(new Question(1,"What is CarWale?",5,1, "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            Questions.Add(new Question(2,"What is CarTrade?",5,4, "Bhavartha","bhavartha@carwale.com", DateTime.Now));
            Questions.Add(new Question(3,"What is BikeWale?",2,4, "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            return Questions;
        }
        
    }

}