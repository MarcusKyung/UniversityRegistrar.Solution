using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;


namespace UniversityRegistrar.Models
{
  public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "The student's name can't be empty!")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "The item'student's enrollment date description can't be empty!")]
        public DateTime EnrollmentDate { get; set; }
        public List<CourseStudent> JoinEntities { get;} //collection navigation property

    }
}