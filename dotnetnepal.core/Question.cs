using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetnepal.core
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public int QuestionNumber { get; set; }

        public Subject Subjects { get; set; }

        public string Text { get; set; }

        public int ExamId { get; set; }

        //only 4
        public List<Answer> Answers { get; set; }
    }
}