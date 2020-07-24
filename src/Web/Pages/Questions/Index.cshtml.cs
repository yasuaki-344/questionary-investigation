using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;
using QuestionaryInvestigation.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryInvestigation.Web.Pages.Questions
{
    public class IndexModel : PageModel
    {
        private readonly IQuestionaryInvestigationRepository _repository;

        public IndexModel(IQuestionaryInvestigationRepository repository)
        {
            _repository = repository;
        }

        public IList<Question> Question { get; set; } = new List<Question>();

        public async Task OnGetAsync()
        {
            Question = await _repository.GetAllQuestionsAsync();
        }
    }
}