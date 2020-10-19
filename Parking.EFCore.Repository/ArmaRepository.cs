using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Repository
{
    public class ArmaRepository : BaseRepository<Arma>, IArmaRepository
    {
        public ArmaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(Arma arma)
        {
            throw new NotImplementedException();
        }

        public Arma Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arma> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Arma Arma)
        {
            throw new NotImplementedException();
        }
    }
}
