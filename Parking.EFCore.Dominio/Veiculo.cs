namespace Parking.EFCore.Dominio
{
    public class Veiculo : BaseModel
    {
        
        public int Id { get; set; }
        
        public string Marca { get; set; }
        
        public string Modelo { get; set; }
        
        public string Cor { get; set; }
        
        public string Placa { get; set; }
        
        public string Tipo { get; set; }
    }
}
