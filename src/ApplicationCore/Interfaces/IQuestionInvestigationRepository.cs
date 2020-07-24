using QuestionaryInvestigation.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.ApplicationCore.Interfaces
{
    public interface IQuestionaryInvestigationRepository
    {
        Task<IList<Question>> GetAllQuestionsAsync();
        Task<Question> GetQuestionByIdAsync(int? id);
        Task<Question> FindQuestionByIdAsync(int? id);
        Task CreateQuestionAsync(Question question);
        Task RemoveQuestionAsync(Question question);
    }
}