using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetnepal.core
{
    public class Exam
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; } //timespan
        public DateTime EndTime { get; set; }

        public string Name { get; set; }

        public TimeSpan Duration { get; set; }

        public UserExam UserExam { get; set; }
    }
}