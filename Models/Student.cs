using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontEnd.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int EnrollmenId { get; set; }
        public string Grade { get; set; }
        public int CourseId  { get; set; }
        public string Title  { get; set; }
        public int Credits  { get; set; }
    }
}