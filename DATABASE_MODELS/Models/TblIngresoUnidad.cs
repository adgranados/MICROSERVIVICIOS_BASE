﻿using System;

namespace DATABASE_MODELS.Models
{
    public partial class TblIngresoUnidad
    {
        public int IdIngreso { get; set; }
        public int? PersoId { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}