using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_Server.Models
{
    public class CCourse
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public int SemesterNumber { get; set; }

        public List<CStudent> Students { get; set; }
    }
}