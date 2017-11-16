namespace dotnetnepal.exittests.Infrastructure
{
    using dotnetnepal.core;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="ApplicationDbContext" />
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The <see cref="DbContextOptions{ApplicationDbContext}"/></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// The OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>();

            modelBuilder.Entity<AnswerHistory>();

            modelBuilder.Entity<Exam>();

            modelBuilder.Entity<ExamQuestion>();

            modelBuilder.Entity<Question>()
                .HasMany(m => m.Answers)
                .WithOne();

            modelBuilder.Entity<QuestionAnswer>();

            modelBuilder.Entity<QuestionHistory>();

            modelBuilder.Entity<Score>();

            modelBuilder.Entity<Subject>();

            modelBuilder.Entity<User>();

            modelBuilder.Entity<UserExam>();

            modelBuilder.Entity<UserQuestionAnswer>();

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Gets or sets the Answers
        /// </summary>
        public DbSet<Answer> Answers { get; set; }

        /// <summary>
        /// Gets or sets the AnswerHistory
        /// </summary>
        public DbSet<AnswerHistory> AnswerHistory { get; set; }

        /// <summary>
        /// Gets or sets the Exams
        /// </summary>
        public DbSet<Exam> Exams { get; set; }

        /// <summary>
        /// Gets or sets the ExamQuestions
        /// </summary>
        public DbSet<ExamQuestion> ExamQuestions { get; set; }

        /// <summary>
        /// Gets or sets the Questions
        /// </summary>
        public DbSet<Question> Questions { get; set; }

        /// <summary>
        /// Gets or sets the QuestionAnswers
        /// </summary>
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }

        /// <summary>
        /// Gets or sets the QuestionHistory
        /// </summary>
        public DbSet<QuestionHistory> QuestionHistory { get; set; }

        /// <summary>
        /// Gets or sets the Scores
        /// </summary>
        public DbSet<Score> Scores { get; set; }

        /// <summary>
        /// Gets or sets the Subjects
        /// </summary>
        public DbSet<Subject> Subjects { get; set; }

        /// <summary>
        /// Gets or sets the UserExams
        /// </summary>
        public DbSet<UserExam> UserExams { get; set; }

        /// <summary>
        /// Gets or sets the UserQuestionAnswers
        /// </summary>
        public DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }
    }
}