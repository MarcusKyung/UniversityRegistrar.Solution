using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;


namespace UniversityRegistrar.Models
{
  public class Department
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "The department's name can't be empty!")]
        public string DepartmentName { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}