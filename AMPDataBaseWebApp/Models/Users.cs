using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class Users
    {
        public short Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }
}
