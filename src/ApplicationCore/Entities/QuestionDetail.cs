
namespace QuestionaryInvestigation.ApplicationCore.Entities
{
    public class QuestionChoice
    {
        public int QuestionChoiceID { get; set; }
        public string QuestionString { get; set; } = string.Empty;
        public Question? Question { get; set; }
    }
}