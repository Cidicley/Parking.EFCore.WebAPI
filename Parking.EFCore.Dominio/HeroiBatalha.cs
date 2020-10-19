using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Dominio
{
    public class HeroiBatalha : BaseModel
    {
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }

        public int BatalhaId { get; set; }        
        public Batalha Batalha { get; set; }
    }
}
