using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            StudentInCourses = new HashSet<StudentInCourse>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Code { get; set; } = null!;
        public int? MajorId { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }

        public virtual Major? Major { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<StudentInCourse> StudentInCourses { get; set; }
    }
}
