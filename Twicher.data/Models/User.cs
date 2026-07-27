using System;
using System.Collections.Generic;
using System.Text;
using Twicher.Data.Models;

namespace Twicher.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? ProfilePictureUrl { get; set; }


        //Navigation Properties
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
