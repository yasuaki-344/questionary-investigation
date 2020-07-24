using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using QuestionaryInvestigation.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public class QuestionaryInvestigationRepository : IQuestionaryInvestigationRepository
{
    private readonly ApplicationDbContext _context;

    public QuestionaryInvestigationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IList<Question>> GetAllQuestionsAsync() =>
        await _context.Question.ToListAsync();

    public async Task<Question> GetQuestionByIdAsync(int? id)
    {
        if (id != null)
        {
            return await _context.Question
                .Include(s => s.QuestionChoices)
                .FirstOrDefaultAsync(m => m.QuestionID == id);
        }
        else
        {
            return null;
        }
    }
    public async Task<Question> FindQuestionByIdAsync(int? id)
    {
        if (id != null)
        {
            return await _context.Question.FindAsync(id);
        }
        else
        {
            return null;
        }
    }

    public async Task CreateQuestionAsync(Question question)
    {
        _context.Question.Add(question);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveQuestionAsync(Question question)
    {
        _context.Question.Remove(question);
        await _context.SaveChangesAsync();
    }

}