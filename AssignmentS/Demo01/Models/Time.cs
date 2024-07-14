using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Demo01.Models
{
    [Table("Time")]
    public class Time
    {

            [Column("BatchId", TypeName = "System.Int32")]
            [Key]
            public int BatchId { get; set; }

            [Column("Course", TypeName = "System.String")]
            [StringLength(50)]
            public string Course { get; set; }

            [Column("BatchName", TypeName = "System.String")]
            [StringLength(50)]
            public string BatchName { get; set; }


            [Column("Gst", TypeName = "System.Int32")]
            
            public int Gst { get; set; }

            [Column("TotalFee", TypeName = "System.Int32")]
            [StringLength(50)]
            public string TotalFee { get; set; }
        }

        public class KDACDBContext : DbContext
        {
            public KDACDBContext(DbContextOptions options) : base(options)
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
            }

            public DbSet<Time> Time { get; set; }
        }
}


