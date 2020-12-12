namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class AnswerDetail
    {
        public int AnswerDetailID { get; set; }
        public string AnswerDetailString { get; set; } = string.Empty;

        public int AnswerID { get; set; }
        public Answer Answer { get; set; } = new Answer();

        public int QuestionID { get; set; }
        public Question Question { get; set; } = new Question();
    }
}