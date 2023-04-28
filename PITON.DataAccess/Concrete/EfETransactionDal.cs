using System;
using System.Linq.Expressions;

using PITON.Core.DataAccess.EntityFramework;
using PITON.DataAccess.Abstract;
using PITON.Entity;

namespace PITON.DataAccess.Concrete
{
    public class EfETransactionDal : EfEntityRepositoryBase<ETransaction, Context>, IETransactionDal
    {
        
    }
}

