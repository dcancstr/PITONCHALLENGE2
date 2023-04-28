using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using PITON.Entity;

namespace PITON.DataAccess
{
	public class Context :DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PitonDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True");
        }

        public DbSet<ETransaction> ETransactions { get; set; }

        
    }
}

