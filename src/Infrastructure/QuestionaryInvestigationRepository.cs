using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using QuestionaryInvestigation.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class QuestionaryInvestigationRepository : IQuestionaryInvestigationRepository
{
    private readonly ApplicationDbContext _context;

    public QuestionaryInvestigationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public bool QuestionExists(int id) =>
        _context.Question.Any(e => e.QuestionID == id);

    public async Task<IList<Question>> GetAllQuestionsAsync() =>
        await _context.Question.AsNoTracking().ToListAsync();

    public async Task<Question> GetQuestionByIdAsync(int? id)
    {
        if (id != null)
        {
            return await _context.Question
                .Include(s => s.QuestionChoices)
                .AsNoTracking()
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
            return await _context.Question
                .Include(s => s.QuestionChoices)
                .AsNoTracking()
                .FirstAsync(m => m.QuestionID == id);
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

    public async Task UpdateQuestionAsync(Question question)
    {
        var choices = _context.QuestionChoice
            .Where(e => e.QuestionID == question.QuestionID);
        _context.QuestionChoice.RemoveRange(choices);
        _context.Attach(question).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task RemoveQuestionAsync(Question question)
    {
        _context.Question.Remove(question);
        await _context.SaveChangesAsync();
    }

    public async Task<IList<Answer>> GetAllAnswersAsync() =>
        await _context.Answer.AsNoTracking().ToListAsync();
}