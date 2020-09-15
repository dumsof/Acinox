namespace File.Business.Business
{
    using File.Business.IBusiness;
    using File.Entities;
    using File.Repositorie.IRepositorie;
    using File.Repositorie.Repositorie;
    using System.Collections.Generic;

    public class SocietieBusiness : ISocietieBusiness
    {
        private readonly IRepositorieSocietie repositorie;

        public SocietieBusiness()
        {
            this.repositorie = new RepositorieSocietie();
        }

        public IEnumerable<EntitieSocieties> GetSocieties()
        {
            return this.repositorie.GetSocieties();
        }
    }
}