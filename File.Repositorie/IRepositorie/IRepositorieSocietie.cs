namespace File.Repositorie.IRepositorie
{
    using File.Entities;
    using System.Collections.Generic;

    public interface IRepositorieSocietie
    {
        IEnumerable<EntitieSocieties> GetSocieties();
    }
}