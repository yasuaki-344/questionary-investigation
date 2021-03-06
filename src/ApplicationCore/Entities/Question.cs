
using System.Collections.Generic;

namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Type { get; set; }
        public int Sort { get; set; }
        public List<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();
    }
}