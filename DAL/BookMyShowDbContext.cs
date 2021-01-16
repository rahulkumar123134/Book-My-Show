using WebData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.DAL
{
    public class BookMyShowDbContext: DbContext
    {
        public BookMyShowDbContext(DbContextOptions<BookMyShowDbContext> options): base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
