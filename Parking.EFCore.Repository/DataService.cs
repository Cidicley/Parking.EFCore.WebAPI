using Parking.EFCore.Repository.Interface;

namespace Parking.EFCore.Repository
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IVeiculoRepository veiculoRepository;
        private readonly IEstabelecimentoRepository estabelecimentoRepository;        
        

        public DataService(ApplicationContext contexto,
            IVeiculoRepository veiculoRepository,
            IEstabelecimentoRepository estabelecimentoRepository
            
            )
        {
            this.contexto = contexto;
            this.veiculoRepository = veiculoRepository;
            this.estabelecimentoRepository = estabelecimentoRepository;
            
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
        }
    }
}
