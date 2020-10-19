using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IBatalhaRepository
    {
        void Add(Batalha batalha);
        IEnumerable<Batalha> GetAll();
        Batalha Find(long id);
        void Remove(long id);
        void Update(Batalha Batalha);
    }
}
