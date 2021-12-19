using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontEnd.Models
{
    public class Student
    {
        public string StudentId { get; set; }
          [Required(ErrorMessage ="Student ID is required")]
      
        public string FirstName { get; set; }
         [Required]
           public string LastName { get; set; }
          [Required]
        public DateTime EnrollmentDate { get; set; }
         [Required]
        public int EnrollmenId { get; set; }
        public string Grade { get; set; }
        public int CourseId  { get; set; }
        public string Title  { get; set; }
        public int Credits  { get; set; }
    }
}