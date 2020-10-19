using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IEstacionamentoRepository
    {
        void Add(Estacionamento estacionamento);
        IEnumerable<Estacionamento> GetAll();
        Estacionamento Find(long id);
        void Remove(long id);
        void Update(Estacionamento estacionamento);
    }
}
