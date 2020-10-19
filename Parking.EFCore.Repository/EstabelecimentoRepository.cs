using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Parking.EFCore.Repository
{
    public class EstabelecimentoRepository : BaseRepository<Estabelecimento>, IEstabelecimentoRepository
    {
        public EstabelecimentoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public bool Add(Estabelecimento estabelecimento)
        {
            var _cnpj = this.GetAll().FirstOrDefault(e => e.Cnpj == estabelecimento.Cnpj);

            if ((_cnpj == null) || (_cnpj.Cnpj != estabelecimento.Cnpj))
            {
                dbSet.Add(estabelecimento);
                contexto.SaveChanges();
                return true;
            }

            return false;
        }

        public int CapacidadeMaxVaga(long id, string tipoVeiculo)
        {
            int vagas = 0;

            var estacionamento = this.Find(id);


            if (tipoVeiculo == "CARRO")//carro
            {
                vagas = estacionamento.QuantidadeVagaCarro;
            }
            else
            {
                vagas = estacionamento.QuantidadeVagaMoto;
            }

            return vagas;                   

            //throw new System.NotImplementedException();
        }

        public Estabelecimento Find(long id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Estabelecimento> GetAll()
        {
            return dbSet.ToList();
        }

        public void Remove(long id)
        {
            var estabelecimento = Find(id);
            dbSet.Remove(estabelecimento);
            contexto.SaveChanges();
        }

        public void Update(Estabelecimento estabelecimento)
        {
            dbSet.Update(estabelecimento);
            contexto.SaveChanges();
        }
    }
}
