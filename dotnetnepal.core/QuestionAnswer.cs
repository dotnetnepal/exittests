using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetnepal.core
{
    public class QuestionAnswer
    {
        public int QuestionHistoryId { get; set; }
        public int AnswerHistoryId { get; set; }
        public bool IsCorrect { get; set; }
    }
}