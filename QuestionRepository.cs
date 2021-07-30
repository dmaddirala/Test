using System;
using System.Collections.Generic;

namespace QnA
{
    class QuestionRepository
    {
        private List<Question> Questions { get; set; }

        public QuestionRepository(){
            this.Questions = new List<Question>();
        }

    }
}