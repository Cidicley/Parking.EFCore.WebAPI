using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Repository
{
    public class BatalhaRepository : BaseRepository<Batalha>, IBatalhaRepository
    {
        public BatalhaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(Batalha batalha)
        {
            throw new NotImplementedException();
        }

        public Batalha Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batalha> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Batalha Batalha)
        {
            throw new NotImplementedException();
        }
    }
}
