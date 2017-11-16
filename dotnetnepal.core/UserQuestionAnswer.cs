namespace dotnetnepal.core
{
    public class UserQuestionAnswer
    {
        public int QuestionId { get; set; }

        public int ExamId { get; set; }
        public int QuestionHistoryId { get; set; }
        public int AnswerHistoryId { get; set; }

        public bool IsCorrect { get; set; }
    }
}