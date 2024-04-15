using CiiLOCK.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CiiLOCK.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
	        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mother of All Rollers", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Titan Bifold", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Door Lock & Handle", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Additional Hardware", DisplayOrder = 4 },
                new Category { Id = 5, Name = "SiiGMATIC Testing Services", DisplayOrder = 5 }

            );

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					PartCode = "8179-10",
					Name = "W2 58 Series - C/S - 100KG",
					Description = "Mother of All Rollers - W1 58 Series - C/S - 40KG ",
					ListPrice = 5.5,
					CategoryId = 1

				},
				new Product
				{
					Id = 2,
					PartCode = "8158-202",
					Name = "W1 58 Series - C/S - 40KG",
					Description = "Mother of All Rollers - W2 58 Series - C/S - 100KG",
					ListPrice = 9.5,
					CategoryId = 1

				},
				new Product
				{
					Id = 3,
					PartCode = "8158-302",
					Name = "W2 58 Series - S/S - 100KG",
					Description = "Mother of All Rollers - W2 58 Series - S/S - 100KG ",
					ListPrice = 16.9,
					CategoryId = 1

				},
				new Product
				{
					Id = 4,
					PartCode = "8179-10",
					Name = "W3 58 Series - C/S - 150KG",
					Description = "Mother of All Rollers - W3 58 Series - C/S - 150KG",
					ListPrice = 24.0,
					CategoryId = 1

				},
				new Product
				{
					Id = 5,
					PartCode = "8187-302",
					Name = "W3 58 Series - S/S - 150KG",
					Description = "Mother of All Rollers - W3 58 Series - S/S - 150KG ",
					ListPrice = 38.0,
					CategoryId = 1

				},
				new Product
				{
					Id = 6,
					PartCode = "8275-202",
					Name = "W5 58 Series C/S 200Kg",
					Description = "Mother of All Rollers - W5 58 Series C/S 200Kg",
					ListPrice = 42.0,
					CategoryId = 1

				}
			);
		}
    }
}
