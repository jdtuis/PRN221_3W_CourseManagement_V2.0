using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public int? StudentId { get; set; }
        public string? Status { get; set; }

        public virtual Session? Session { get; set; }
        public virtual Student? Student { get; set; }
    }
}
