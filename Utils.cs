using System;
using System.Collections.Generic;

namespace QnA
{
    class Utils
    {
        public List<Question> GenerateQuestions(){
            var Questions = new List<Question>() ;
            Questions.Add(new Question("What is CarWale?", "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            Questions.Add(new Question("What is CarTrade?", "Bhavartha","bhavartha@carwale.com", DateTime.Now));
            Questions.Add(new Question("What is BikeWale?", "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            return Questions;
        }
        
    }

}