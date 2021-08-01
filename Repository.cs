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