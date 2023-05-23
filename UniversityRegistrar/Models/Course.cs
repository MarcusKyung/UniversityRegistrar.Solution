using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course's name can't be empty!")]
    public string CourseName { get; set; }
    [Required(ErrorMessage = "The course's number can't be empty!")]
    public string CourseNumber { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your course to a department. Have you created a department yet?")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}