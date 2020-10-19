using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository
{
    public interface IVeiculoRepository
    {
        bool Add(Veiculo veiculo);
        IEnumerable<Veiculo> GetAll();
        Veiculo Find(long id);
        void Remove(long id);
        void Update(Veiculo veiculo);
        Veiculo GetPlaca(string placa);
    }
}