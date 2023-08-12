using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Room
    {
        public Room()
        {
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
