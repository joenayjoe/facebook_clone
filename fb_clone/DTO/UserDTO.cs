using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb_clone.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public byte[] CoverPhoto { get; set; }
    }
}
