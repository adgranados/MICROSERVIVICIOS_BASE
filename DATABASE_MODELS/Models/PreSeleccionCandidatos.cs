using System;

namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionCandidatos
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public int IdBusqueda { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
