using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using QuestionaryInvestigation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.Web.Pages.Questions
{
    public class CreateModel : PageModel
    {
        private readonly IQuestionaryInvestigationRepository _repository;

        public CreateModel(IQuestionaryInvestigationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Question Question { get; set; } = new Question();

        [BindProperty]
        public List<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Question.QuestionChoices = QuestionChoices;

            await _repository.CreateQuestionAsync(Question);

            return RedirectToPage("./Index");
        }
    }
}