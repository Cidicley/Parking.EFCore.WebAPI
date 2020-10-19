using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Parking.EFCore.Repository
{
    public class EstabelecimentoRegistroVeivuloRepository : BaseRepository<EstabelecimentoRegistroVeivulo>, IEstabelecimentoRegistroVeivuloRepository
    {
        public EstabelecimentoRegistroVeivuloRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(EstabelecimentoRegistroVeivulo estabelecimentoRegistroVeivulo)
        {
            dbSet.Add(estabelecimentoRegistroVeivulo);
            contexto.SaveChanges();
        }

        public IEnumerable<EstabelecimentoRegistroVeivulo> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
