using CiiLOCK.Models;

namespace CiiLOCK_DataAccess.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
	void Update(Category obj);

}