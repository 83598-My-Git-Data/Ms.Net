using Demo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    [Table("Contact")]
    public class Contact
    { 
        [Column("Id", TypeName = "System.Int32")]
        [Key]
        public int Id { get; set; }

        [Column("FirstName", TypeName = "System.String")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "System.String")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("Address", TypeName = "System.String")]
        [StringLength(50)]
        public string Address { get; set; }

        [Column("MobileNo", TypeName = "System.String")]
        [StringLength(50)]
        public string MobileNo { get; set; }
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

        public DbSet<Contact> Contacts { get; set; }

    }
}

