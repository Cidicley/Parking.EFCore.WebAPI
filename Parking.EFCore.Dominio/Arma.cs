﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.EFCore.Dominio
{
    public class Arma : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}
