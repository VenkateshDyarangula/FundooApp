using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Model
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
