using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Course
    {
        public Course()
        {
            Sessions = new HashSet<Session>();
            StudentInCourses = new HashSet<StudentInCourse>();
        }

        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public string Code { get; set; } = null!;
        public int? SemesterId { get; set; }
        public int? SessionNumber { get; set; }
        public string? Status { get; set; }

        public virtual Semester? Semester { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<StudentInCourse> StudentInCourses { get; set; }
    }
}
