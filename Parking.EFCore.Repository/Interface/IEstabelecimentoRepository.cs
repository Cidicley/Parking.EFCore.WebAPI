using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IEstabelecimentoRepository
    {
        bool Add(Estabelecimento estabelecimento);
        IEnumerable<Estabelecimento> GetAll();
        Estabelecimento Find(long id);
        void Remove(long id);
        void Update(Estabelecimento estabelecimento);
        int CapacidadeMaxVaga(long id, string tipoVeiculo);
    }
}
