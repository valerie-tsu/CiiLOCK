

using System.Linq.Expressions;
using CiiLOCK.DataAccess.Data;
using CiiLOCK_DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CiiLOCK_DataAccess.Repository;

public class Repository<T> : IRepository<T> where T:class
{
	private readonly ApplicationDbContext _dbContext;

	internal DbSet<T> dbSet;
	private ApplicationDbContext _db;

	public Repository(ApplicationDbContext db)
	{
		_db = db;
		this.dbSet = _db.Set<T>();
		
	}



	public T Get(Expression<Func<T, bool>> filter)
	{
		IQueryable<T> query = dbSet;
		query = query.Where(filter);
		return query.FirstOrDefault();
	}

	public void Add(T entity)
	{
		dbSet.Add(entity);
	}

	public IEnumerable<T> GetAll()
	{
		IQueryable<T> query = dbSet;
		return query.ToList();
	}

	public void Remove(T entity)
	{
		dbSet.Remove(entity);
	}

	public void RemoveRange(IEnumerable<T> entity)
	{
		dbSet.RemoveRange(entity);
	}

}

public class T
{
}