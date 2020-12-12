
namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class QuestionChoice
    {
        public int QuestionChoiceID { get; set; }
        public string QuestionString { get; set; } = string.Empty;

        public int QuestionID { get; set; }
        public Question Question { get; set; } = new Question();
    }
}