using System;
using ASPNETMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // sends a Db set of category (our model) to the database
        public DbSet<Category> Category { get; set; }
    }
}
