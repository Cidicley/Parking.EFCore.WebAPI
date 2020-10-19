using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IEstabelecimentoRegistroVeivuloRepository
    {
        void Add(EstabelecimentoRegistroVeivulo estabelecimentoRegistroVeivulo  );
        IEnumerable<EstabelecimentoRegistroVeivulo> GetAll();
    }
}
