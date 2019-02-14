using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCoreMovie;

namespace MVCCoreMovie.Models
{
    public class MVCCoreMovieContext : DbContext
    {
        public MVCCoreMovieContext (DbContextOptions<MVCCoreMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCoreMovie.Movie> Movie { get; set; }
    }
}
