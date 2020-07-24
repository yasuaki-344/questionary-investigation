using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using QuestionaryInvestigation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.Web.Pages.Questions
{
    public class DeleteModel : PageModel
    {
        private readonly IQuestionaryInvestigationRepository _repository;
        public DeleteModel(IQuestionaryInvestigationRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Question? Question { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question = await _repository.GetQuestionByIdAsync(id);

            if (Question == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question = await _repository.FindQuestionByIdAsync(id);

            if (Question != null)
            {
                await _repository.RemoveQuestionAsync(Question);
            }

            return RedirectToPage("./Index");
        }
    }
}