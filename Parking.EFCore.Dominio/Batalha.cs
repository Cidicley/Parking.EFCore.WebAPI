using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Dominio
{
    public class Batalha : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }
    }
}
