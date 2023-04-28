using System;
using System.Linq.Expressions;
using PITON.Entity;

namespace PITON.Business.Abstract
{
	public interface IETransactionService
	{
        List<ETransaction> GetAll(Expression<Func<ETransaction, bool>> filter = null);
        void Add(ETransaction todos);
    }
}

