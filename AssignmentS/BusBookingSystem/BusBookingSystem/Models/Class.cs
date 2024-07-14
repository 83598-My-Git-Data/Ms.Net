using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BusBookingSystem.Models
{
    [Table(name: "Bus")]
    public class Bus
    {
        [Column("BusId", TypeName = "int")]
        [Key]
        public int BusId { get; set; }
        [Column("BusNumber", TypeName = "varchar")]
        [StringLength(50)]
        public string BusNumber { get; set; }
        [Column("Capacity", TypeName = "int")]
        public int Capacity { get; set; }

        [Column("BusType", TypeName = "varchar")]
        [StringLength(50)]
        public string BusType { get; set; }
        public DbSet<Seat> Seats { get; set; }
    }
       [Table(name: "Seat")]
        public class Seat
        {
            [Key]
            public int SeatId { get; set; }
            public int BusId { get; set; }
            public int SeatNumber { get; set; }
            public bool IsAvailable { get; set; }

        //[ForeignKey("BusId")]
        //public Bus Bus { get; set; }
        public DbSet<Bus> Buses { get; set; }

    }

        [Table(name: "User")]
        public class User
        {
            [Key]
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public bool IsLoggedIn { get; set; }
        }

    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions options): base(options)
            {
                
            }

            public DbSet<Bus> Buses { get; set; }
            public DbSet<Seat> Seats { get; set; }
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
            }
           
           
        }
}
