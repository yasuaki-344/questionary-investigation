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
    public class IndexModel : PageModel
    {
        private readonly QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext _context;

        public IndexModel(QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Answer> Answer { get; set; }

        public async Task OnGetAsync()
        {
            Answer = await _context.Answer.ToListAsync();
        }
    }
}