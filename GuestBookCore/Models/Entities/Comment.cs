using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBookCore.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
