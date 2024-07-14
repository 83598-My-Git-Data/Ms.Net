
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Models
{
    [Table("Seller")]
    public class Seller
    {
        [Column(name: "SellerId", TypeName = "int")]
        [Key]
        public int SellerId { get; set; }

        [Column(name: "SellerName", TypeName = "Varchar")]
        [StringLength(50)]
        public string SellerName { get; set; }

        [Column(name: "Email", TypeName = "Varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(name: "Password", TypeName = "Varchar")]
        [StringLength(50)]
        public string Password { get; set; }
    }

    [Table("Products")]
    public class Products
    {
        [Column(name: "ProductId", TypeName = "int")]
        [Key]
        public int ProductId { get; set; }

        [Column(name: "ProductName", TypeName = "Varchar")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(name: "Description", TypeName = "Varchar")]
        [StringLength(50)]
        public string Description { get; set; }

        [Column(name: "Price", TypeName = "Decimal")]

        public double Price { get; set; }

        [Column(name: "Category", TypeName = "Varchar")]
        [StringLength(50)]
        public string Category { get; set; }

        [Column(name: "Stock_Quantity", TypeName = "int")]
        public int Stock_Quantity { get; set; }

        [Column(name:"seller")]
        public Seller seller { get; set; }


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
        public DbSet<Seller> sellers { get; set; }

        public DbSet<Products> products { get; set; }
        
    }
}
