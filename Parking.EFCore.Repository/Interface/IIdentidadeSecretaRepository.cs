using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IIdentidadeSecretaRepository
    {
        void Add(IdentidadeSecreta identidadeSecreta);
        IEnumerable<IdentidadeSecreta> GetAll();
        IdentidadeSecreta Find(long id);
        void Remove(long id);
        void Update(IdentidadeSecreta identidadeSecreta);
    }
}
