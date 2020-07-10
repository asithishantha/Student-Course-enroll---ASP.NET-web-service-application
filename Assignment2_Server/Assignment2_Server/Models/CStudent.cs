using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_Server.Models
{
    public class CStudent
    {

        public int StudentId { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        
        public string ContactPerson { get; set; }

        public List<CCourse> Courses { get; set; }
    }
}