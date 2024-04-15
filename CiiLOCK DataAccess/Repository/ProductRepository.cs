using CiiLOCK.DataAccess.Data;
using CiiLOCK.Models;
using CiiLOCK_DataAccess.Repository.IRepository;

namespace CiiLOCK_DataAccess.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
	private ApplicationDbContext _db;

	public ProductRepository(ApplicationDbContext db) : base(db)
	{
		_db = db;
	}



	public void Update(Product obj)
	{
		_db.Products.Update(obj);
	}
}