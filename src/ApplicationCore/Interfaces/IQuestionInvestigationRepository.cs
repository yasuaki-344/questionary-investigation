using QuestionaryInvestigation.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.ApplicationCore.Interfaces
{
    public interface IQuestionaryInvestigationRepository
    {
        Task<IList<Question>> GetAllQuestionsAsync();
        Task<Question> GetQuestionByIdAsync(int? id);
        Task CreateQuestionAsync(Question question);
    }
}