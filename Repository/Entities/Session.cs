using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Session
    {
        public Session()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public int SessionIndex { get; set; }
        public int? CourseId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Status { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Room? Room { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
