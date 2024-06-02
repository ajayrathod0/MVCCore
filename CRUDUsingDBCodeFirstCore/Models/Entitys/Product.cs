using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUDUsingDBCodeFirstCore.Models.Entitys
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column("ProductName", TypeName = "varchar(50)")]
        public string ProductName { get; set; }

        public int Price { get; set; }

         
    }
}
