using System;
using System.Collections.Generic;
using System.Text;
using Twicher.Data.Models;

namespace Twicher.Data.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }

        // Foreign key
        public int UserId { get; set; }

        //Navigation properties
        public User User { get; set; }
    }
}