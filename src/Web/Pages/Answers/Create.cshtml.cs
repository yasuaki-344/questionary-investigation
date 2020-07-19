using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.Infrastructure.Data;

namespace QuestionaryInvestigation.Web.Pages.Answers
{
    public class CreateModel : PageModel
    {
        private readonly QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext _context;

        public CreateModel(QuestionaryInvestigation.Infrastructure.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Answer Answer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Answer.Add(Answer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
