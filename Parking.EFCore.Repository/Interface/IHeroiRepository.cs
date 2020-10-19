using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IHeroiRepository
    {
        void Add(Heroi heroi);
        IEnumerable<Heroi> GetAll();
        Heroi Find(long id);
        void Remove(long id);
        void Update(Heroi heroi);
    }
}
