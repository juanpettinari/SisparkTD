﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SisParkTD.Models
{
    public class Abono
    {
        [Key]
        public int AbonoId { get; set; }
        [Required]
        public int CuentaId { get; set; }
        [Required]
        public int ParcelaId { get; set; }
        [Required]
        public DateTime FechaMesInicio { get; set; }

        public DateTime? FechaMesFin { get; set; }

        public virtual Parcela Parcela { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}