using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<CourseStudent> JoinEntities { get;} //collection navigation property

    }
}