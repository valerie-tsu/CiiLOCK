using CiiLOCK.DataAccess.Data;
using CiiLOCK.Models;
using CiiLOCK_DataAccess.Repository.IRepository;

namespace CiiLOCK_DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
	private ApplicationDbContext _db;

	public CategoryRepository(ApplicationDbContext db) : base(db)
	{
		_db = db;
	}



	public void Update(Category obj)
	{
		_db.Categories.Update(obj);
	}
}