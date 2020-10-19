using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Repository
{
    public class IdentidadeSecretaRepository : BaseRepository<IdentidadeSecreta>, IIdentidadeSecretaRepository
    {
        public IdentidadeSecretaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(IdentidadeSecreta identidadeSecreta)
        {
            throw new NotImplementedException();
        }

        public IdentidadeSecreta Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentidadeSecreta> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(IdentidadeSecreta identidadeSecreta)
        {
            throw new NotImplementedException();
        }
    }
}
