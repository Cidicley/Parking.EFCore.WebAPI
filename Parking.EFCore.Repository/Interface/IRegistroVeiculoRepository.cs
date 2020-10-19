using Parking.EFCore.Dominio;
using System.Collections.Generic;

namespace Parking.EFCore.Repository.Interface
{
    public interface IRegistroVeiculoRepository
    {
        void Add(RegistroVeiculo registroVeiculo);
        IEnumerable<RegistroVeiculo> GetAll();
        RegistroVeiculo Find(long id);
        void Remove(long id);
        void Update(RegistroVeiculo registroVeiculo);
        bool EntradaVeiculo(RegistroVeiculo registroVeiculo);        
        bool SaidaVeiculo(Veiculo veiculo);
    }
}
