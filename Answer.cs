using System;
using System.Collections.Generic;

namespace QnA
{
    public class Answer
    {
        public string Title { get; set;}
        public int UpVote { get; set;}
        public int DownVote { get; set;}
        public string UserName { get; set;}
        public string UserEmailId { get; set;}
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public Answer(string title, string userName, string userEmailId, DateTime entryDate){
            this.Title = title;
            this.UserName = userName;
            this.UserEmailId = userEmailId;
            this.EntryDate = entryDate ;
        }

    }
}

// 1. QnA Moderation process -> Question and answer should be visible only if is approved 
// Question: Title, UpVote,DownVote, UserName, UserEmailId, AskedDate,Updateon 
// Answer: answer,upvote,donwvote,username,useremailId,answereddate,Updateon Note: Question -> multiple answer 
// Microservice: 
// 1. QnA Create/Delete 
// 2. QnA -> Get 
//       1. Question Details 
//       2. Question all answer answer 
//       3. Question top answer(Single answer -> upvote, or latest one)
// Filter: FuelType, Model(Swift, Alto)