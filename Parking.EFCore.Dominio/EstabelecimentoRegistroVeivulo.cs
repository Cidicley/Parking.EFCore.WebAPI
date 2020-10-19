namespace Parking.EFCore.Dominio
{
    public class EstabelecimentoRegistroVeivulo: BaseModel
    {
        /*
        public int EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }

        public int RegistroVeiculoId { get; set; }
        public RegistroVeiculo RegistroVeiculo { get; set; }
        */

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
