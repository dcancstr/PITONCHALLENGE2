using System;
using System.Linq.Expressions;
using PITON.Core.Entities;

namespace PITON.Core.DataAccess
{
	public interface IEntityRepository<T> where T :class,IEntity,new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		void Add(T entity); 
	}
}

