using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetnepal.core
{
    public class UserExam
    {
        public int Id { get; set; }

        public int AnswerId { get; set; }
        public int QuestionId { get; set; }

        public int UserId { get; set; }
    }
}