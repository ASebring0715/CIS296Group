using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SportsPro.Models
{
	
    public class Product
    {
		public int ProductID { get; set; }
		[Required(ErrorMessage = "Please enter a Product Code.")]
		public string ProductCode { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Product Name.")]
		public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Price.")]
        [Column(TypeName = "decimal(8,2)")]
		public decimal YearlyPrice { get; set; }
		public DateTime ReleaseDate { get; set; } = DateTime.Now;
	}
}
