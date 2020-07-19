using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.Web.Pages.Answers
{
    public class DetailsModel : PageModel
    {
        private readonly QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext _context;

        public DetailsModel(QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Answer Answer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Answer = await _context.Answer.FirstOrDefaultAsync(m => m.AnswerID == id);

            if (Answer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}