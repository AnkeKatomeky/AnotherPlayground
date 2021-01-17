using System;
using Microsoft.EntityFrameworkCore;

namespace My.Entity.Model
{
    public class UsersContext : DbContext
    {
        public DbSet<SiteUser> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}