
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Model;
using System;

namespace BookTest.Data
{
    public class RazorPagesMovieDBContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
       

        /// <summary>
        /// DB path (Data base location)
        /// </summary>
        public string DbPath { get; private set; }

        public RazorPagesMovieDBContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}MovieDB.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
