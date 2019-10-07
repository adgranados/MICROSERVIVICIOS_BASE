using System;

namespace DATABASE_MODELS.Models
{
    public partial class TblIngresoDemandante
    {
        public int IdIngreso { get; set; }
        public int? PersoId { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
