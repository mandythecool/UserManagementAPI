using Microsoft.EntityFrameworkCore;
using SampleWebApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
