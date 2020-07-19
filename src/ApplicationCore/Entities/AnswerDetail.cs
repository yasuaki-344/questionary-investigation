namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class AnswerDetail
    {
        public int AnswerDetailID { get; set; }
        public string AnswerDetailString { get; set; } = string.Empty;
        public Answer? Answer { get; set; }
        public Question? Question { get; set; }
    }
}