using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public string? Material { get; set; }
        public int? MajorId { get; set; }
        public string? Status { get; set; }

        public virtual Major? Major { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
