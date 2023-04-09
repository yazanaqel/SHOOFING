using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnTest.Data.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OnTest.Models
{
	public class Product
    {
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public double Price { get; set; }
		public ProductCompany ProductCompany { get; set; }
        public ProductCategory ProductCategory { get; set; }

	}
}
