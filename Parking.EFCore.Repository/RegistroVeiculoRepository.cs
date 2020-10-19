using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking.EFCore.Repository
{
    public class RegistroVeiculoRepository : BaseRepository<RegistroVeiculo>, IRegistroVeiculoRepository
    {
        private readonly IEstabelecimentoRepository estabelecimentoRepository;
        private readonly IVeiculoRepository veiculoRepository;

        public RegistroVeiculoRepository(ApplicationContext contexto, 
            IEstabelecimentoRepository estabelecimentoRepository,
            IVeiculoRepository veiculoRepository) : base(contexto)
        {
            this.estabelecimentoRepository = estabelecimentoRepository;
            this.veiculoRepository = veiculoRepository;
        }

        public void Add(RegistroVeiculo registroVeiculo)
        {
            dbSet.Add(registroVeiculo);
            contexto.SaveChanges();
        }

        public bool EntradaVeiculo(RegistroVeiculo registroVeiculo)
        {
            bool temVaga = true;

            try
            {
                Veiculo veiculo = veiculoRepository.Find(registroVeiculo.VeiculoId);

                if (veiculo == null)
                {
                    return false;
                }

                string tipoVeiculo = veiculo.Tipo;

                RegistroVeiculo _regVeic = this.GetAll().Where(r => r.VeiculoId == veiculo.Id && r.VagaEmUso == true).FirstOrDefault();

                if (_regVeic != null)
                {                    
                    return false;
                }

                int capacidadeMaxVeic = estabelecimentoRepository.CapacidadeMaxVaga(registroVeiculo.EstabelecimentoId, tipoVeiculo);
                
                int totalVagaUsando = this.GetAll().Where(t => t.VagaEmUso == true).Count();

                temVaga = (capacidadeMaxVeic - totalVagaUsando) > 0;

                if (temVaga)
                {
                    registroVeiculo.Entrada = true;
                    registroVeiculo.DataEntrada = DateTime.Now;
                    registroVeiculo.Saida = false;
                    registroVeiculo.DataSaida = DateTime.Now;
                    registroVeiculo.VagaEmUso = true;

                    this.Add(registroVeiculo);
                }
            }
            catch (Exception)
            {
                temVaga = false;
            }

            return temVaga;
        }

        public RegistroVeiculo Find(long id)
        {
            return dbSet.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<RegistroVeiculo> GetAll()
        {
            return dbSet.ToList();
        }

        public void Remove(long id)
        {
            var registroVeiculo = Find(id);
            dbSet.Remove(registroVeiculo);
            contexto.SaveChanges();
        }        

        public bool SaidaVeiculo(Veiculo veiculo)
        {
            bool _Saida = false;

            try
            {
                Veiculo _veiculo = veiculoRepository.GetPlaca(veiculo.Placa);

                if (_veiculo == null)
                {
                    return _Saida;
                }
                
                RegistroVeiculo registroVeiculo = this.GetAll().Where(v => v.VeiculoId == _veiculo.Id && v.VagaEmUso == true).FirstOrDefault();

                if (registroVeiculo == null)
                {
                    return _Saida;
                }

                registroVeiculo.DataSaida = DateTime.Now;
                registroVeiculo.Saida = true;
                registroVeiculo.VagaEmUso = false;

                this.Update(registroVeiculo);

                _Saida = true;

            }
            catch (Exception)
            {

                _Saida = false;
            }            

            return _Saida;
        }

        public void Update(RegistroVeiculo registroVeiculo)
        {
            dbSet.Update(registroVeiculo);
            contexto.SaveChanges();
        }
    }
}
