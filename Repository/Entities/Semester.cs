using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Semester
    {
        public Semester()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string? FullName { get; set; }
        public string Code { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
