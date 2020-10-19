using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Parking.EFCore.Repository
{
    public class EstacionamentoRepository : BaseRepository<Estacionamento>, IEstacionamentoRepository
    {
        public EstacionamentoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(Estacionamento estacionamento)
        {
            dbSet.Add(estacionamento);
            contexto.SaveChanges();
        }

        public Estacionamento Find(long id)
        {
            return dbSet.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Estacionamento> GetAll()
        {
            return dbSet.ToList();
        }

        public void Remove(long id)
        {
            var estacionamento = Find(id);
            dbSet.Remove(estacionamento);
            contexto.SaveChanges();
        }

        public void Update(Estacionamento estacionamento)
        {
            dbSet.Update(estacionamento);
            contexto.SaveChanges();
        }
    }
}
