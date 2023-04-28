using System;
using System.Linq.Expressions;
using PITON.Business.Abstract;
using PITON.DataAccess.Abstract;
using PITON.Entity;

namespace PITON.Business.Concrete
{
    public class ETransactionManager : IETransactionService
    {
        private readonly IETransactionDal eTransactionDal;

        public ETransactionManager(IETransactionDal eTransactionDal)
        {
            this.eTransactionDal = eTransactionDal;
        }

        public void Add(ETransaction entity)
        {
            eTransactionDal.Add(entity);
            
        }

        public List<ETransaction> GetAll(Expression<Func<ETransaction, bool>> filter = null)
        {
            return eTransactionDal.GetAll(filter).ToList();
        }
    }
}

