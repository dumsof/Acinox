using File.Entities;
using File.Repositorie.DataAccess;
using File.Repositorie.IRepositorie;
using System;
using System.Collections.Generic;
using System.Linq;

namespace File.Repositorie.Repositorie
{
    public class RepositorieSocietie : IRepositorieSocietie, IDisposable
    {
        private readonly DbContext dbContext;

        public RepositorieSocietie()
        {
            this.dbContext = new DbContext();
        }

       

        public IEnumerable<EntitieSocieties> GetSocieties()
        {
            var societies = this.dbContext.Empresas.Select(c => new EntitieSocieties
            {
                Cod = c.Codigo,
                Razons = c.Descripcion,
                Nif = c.Nit,
                CodMoneda = "01",
            }).ToList();

            return societies;
        }

        protected virtual void Dispose(bool disposing)
        {
            if ( disposing)
            {
                this.dbContext.Dispose();
            }          
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}