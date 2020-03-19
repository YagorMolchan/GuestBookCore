using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuestBookCore.Models.Entities;

namespace GuestBookCore.Data
{
    public class CommentDbContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public CommentDbContext(DbContextOptions<CommentDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
