namespace Parking.EFCore.Dominio
{
    public class Estabelecimento : BaseModel
    {
        
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Cnpj { get; set; }
        
        public string Endereco { get; set; }
        
        public string Telefone { get; set; }
        
        public int QuantidadeVagaMoto { get; set; }
        
        public int QuantidadeVagaCarro { get; set; }
    }
}
