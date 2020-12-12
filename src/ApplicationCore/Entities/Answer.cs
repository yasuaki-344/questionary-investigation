
using System;
using System.Collections.Generic;

namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public DateTime AnswerDatetime { get; set; }
        public List<AnswerDetail> AnswerDetails { get; set; } = new List<AnswerDetail>();
    }
}