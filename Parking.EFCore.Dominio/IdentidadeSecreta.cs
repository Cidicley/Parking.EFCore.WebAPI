using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Dominio
{
    public class IdentidadeSecreta : BaseModel
    {
        public int Id { get; set; }
        public string NomeReal { get; set; }
        
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }


    }
}
