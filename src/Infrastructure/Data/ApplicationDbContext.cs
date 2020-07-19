using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuestionaryInvestigation.ApplicationCore.Entities;

namespace QuestionaryInvestigation.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionChoice> QuestionChoice { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<AnswerDetail> AnswerDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Question>().ToTable("Question");
            builder.Entity<QuestionChoice>().ToTable("QuestionChoice");
            builder.Entity<Answer>().ToTable("Answer");
            builder.Entity<AnswerDetail>().ToTable("AnswerDetail");
        }
    }
}