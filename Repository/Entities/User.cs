using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public int? Role { get; set; }
    }
}
