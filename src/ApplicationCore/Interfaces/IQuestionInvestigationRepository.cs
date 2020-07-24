using QuestionaryInvestigation.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.ApplicationCore.Interfaces
{
    public interface IQuestionaryInvestigationRepository
    {
        Task CreateQuestionAsync(Question question);
    }
}