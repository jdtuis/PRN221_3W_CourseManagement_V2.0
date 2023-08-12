using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Major
    {
        public Major()
        {
            Students = new HashSet<Student>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string MajorName { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Status { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
