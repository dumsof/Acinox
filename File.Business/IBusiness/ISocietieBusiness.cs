﻿namespace File.Business.IBusiness
{
    using File.Entities;
    using System.Collections.Generic;

    public interface ISocietieBusiness
    {
        IEnumerable<EntitieSocieties> GetSocieties();
    }
}