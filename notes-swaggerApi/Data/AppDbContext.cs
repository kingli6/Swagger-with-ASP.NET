using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using notes_swaggerApi.Data.Models;

namespace notes_swaggerApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes => Set<Note>();
        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}