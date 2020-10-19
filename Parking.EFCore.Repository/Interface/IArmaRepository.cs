using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IArmaRepository
    {
        void Add(Arma arma);
        IEnumerable<Arma> GetAll();
        Arma Find(long id);
        void Remove(long id);
        void Update(Arma Arma);
    }
}
