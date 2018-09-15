using Microsoft.EntityFrameworkCore;
using System;
using TAHTSData.Models;

namespace TAHTSData
{
    public class TahtsContext: DbContext
    {
        public TahtsContext(DbContextOptions options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    }
}
