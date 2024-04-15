using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiiLOCK.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Display(Name = "CiiLOCK Part Code")]
		public string PartCode { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }

		[Required]
		[Display(Name ="List Price")]
		public double ListPrice { get; set; }

	
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public Category Category { get; set; }
	}
}
