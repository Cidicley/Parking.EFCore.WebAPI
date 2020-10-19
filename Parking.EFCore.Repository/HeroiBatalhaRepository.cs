using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Repository
{
    public class HeroiBatalhaRepository : BaseRepository<HeroiBatalha>, IHeroiBatalhaRepository
    {
        public HeroiBatalhaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(HeroiBatalha heroiBatalha)
        {
            throw new NotImplementedException();
        }

        public HeroiBatalha Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HeroiBatalha> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(HeroiBatalha heroiBatalha)
        {
            throw new NotImplementedException();
        }
    }
}
