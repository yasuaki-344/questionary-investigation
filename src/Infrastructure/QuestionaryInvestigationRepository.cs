using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using QuestionaryInvestigation.Infrastructure.Data;
using System.Threading.Tasks;

public class QuestionaryInvestigationRepository : IQuestionaryInvestigationRepository
{
    private readonly ApplicationDbContext _context;

    public QuestionaryInvestigationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateQuestionAsync(Question question)
    {
        _context.Question.Add(question);
        await _context.SaveChangesAsync();
    }
}