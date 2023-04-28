using System;
using System.Transactions;
using PITON.Core.DataAccess;
using PITON.Entity;

namespace PITON.DataAccess.Abstract
{
	public interface IETransactionDal: IEntityRepository<ETransaction>
    {
	}
}

