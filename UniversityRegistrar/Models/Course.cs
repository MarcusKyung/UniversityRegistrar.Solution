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
    [Required(ErrorMessage = "The course's department can't be empty!")]
    public string Department { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}