using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetnepal.core
{
    public class Score
    {
        public int Id { get; set; }

        public int QuestionAttempted { get; set; }
        public int CorrectAnswer { get; set; }

        public int UserId { get; set; }
    }
}