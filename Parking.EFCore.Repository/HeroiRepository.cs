using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Repository
{
    public class HeroiRepository : BaseRepository<Heroi>, IHeroiRepository
    {
        public HeroiRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(Heroi heroi)
        {
            throw new NotImplementedException();
        }

        public Heroi Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Heroi> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Heroi heroi)
        {
            throw new NotImplementedException();
        }
    }
}
