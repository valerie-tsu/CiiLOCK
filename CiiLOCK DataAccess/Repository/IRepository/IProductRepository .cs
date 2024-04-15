using CiiLOCK.Models;

namespace CiiLOCK_DataAccess.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
	void Update(Product obj);

}