using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace QnA
{
    class Repository
    {
        private List<Question> Questions { get; set; }

        public Repository(){
            this.Questions = Utils.GenerateQuestions();
        }

        public List<Question> GetQuestions()
        {
            return Questions;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void AddAnswer(Question question, Answer answer )
        {
            question.answers.Add(answer);

        }

        public void UpdateQuestion(Question question, string title, DateTime updateDate)
        {
            question.Title = title;
            question.UpdateDate = updateDate;
        }
        
    }
}