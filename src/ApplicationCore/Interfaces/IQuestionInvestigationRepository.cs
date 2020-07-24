using QuestionaryInvestigation.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.ApplicationCore.Interfaces
{
    public interface IQuestionaryInvestigationRepository
    {
        Task<Question> GetQuestionByIdAsync(int? id);
        Task CreateQuestionAsync(Question question);
    }
}