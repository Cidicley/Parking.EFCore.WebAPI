using System;
using System.Collections.Generic;

namespace Parking.EFCore.Dominio
{
    public class Estacionamento : BaseModel
    {
        public Estacionamento()
        {
        }

        public int Id { get; set; }
        public bool Entrada { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool Saida { get; set; }
        public DateTime DataSaida { get; set; }
        public bool VagaAtiva { get; set; }
        
        //public int EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }

        //public int VeiculoId { get; set; }
        //public Veiculo Veiculo { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}