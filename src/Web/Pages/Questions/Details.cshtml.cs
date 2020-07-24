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
    public class DetailsModel : PageModel
    {
        private readonly IQuestionaryInvestigationRepository _repository;

        public DetailsModel(IQuestionaryInvestigationRepository repository)
        {
            _repository = repository;
        }

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
    }
}