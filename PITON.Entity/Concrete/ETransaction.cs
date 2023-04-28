using System;
using System.ComponentModel.DataAnnotations.Schema;
using PITON.Core.Entities;

namespace PITON.Entity
{
	public class ETransaction : IEntity
	{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
		public DateTime TransactionTime { get; set; }
		public decimal Amount { get; set; }
		public bool TransactionStatus { get; set; }
		public bool TransactionTypes { get; set; }
		public string Rrn { get; set; }
		public string ProvisionNo { get; set; }
		public string BankReferenceNo { get; set; }
		public string CardNumberMasked { get; set; }
		public string CardHolderFullName { get; set; }
	}
}

