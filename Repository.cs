using System;
using System.Collections.Generic;

namespace QnA
{
    class Repository
    {
        private List<Question> Questions { get; set; }

        public Repository(){
            this.Questions = new List<Question>();
        }

        public List<Question> GetQuestions()
        {
            Questions.Add(new Question("What is CarWale?", "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            Questions.Add(new Question("What is CarTrade?", "Bhavartha","bhavartha@carwale.com", DateTime.Now));
            Questions.Add(new Question("What is BikeWale?", "Dhruv","dhruv.maddirala@carwale.com", DateTime.Now));
            return Questions;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void UpdateQuestion(Question question, string title, DateTime updateDate)
        {
            question.Title = title;
            question.UpdateDate = updateDate;
        }
    }
}