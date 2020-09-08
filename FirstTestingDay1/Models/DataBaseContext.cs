using System;
using Microsoft.EntityFrameworkCore;

namespace FirstTestingDay1.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}
