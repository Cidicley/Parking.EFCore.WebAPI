using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IHeroiBatalhaRepository
    {
        void Add(HeroiBatalha heroiBatalha);
        IEnumerable<HeroiBatalha> GetAll();
        HeroiBatalha Find(long id);
        void Remove(long id);
        void Update(HeroiBatalha heroiBatalha);
    }
}
