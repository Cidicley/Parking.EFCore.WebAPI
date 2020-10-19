using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Dominio
{
    public class Heroi : BaseModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        public IdentidadeSecreta IdentidadeSecreta { get; set; }
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }

    }
}
