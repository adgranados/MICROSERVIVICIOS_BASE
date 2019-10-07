using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogCandidatos
    {
        public int IdCandidatos { get; set; }
        public int? InterOrgaId { get; set; }
        public int? ProcesoId { get; set; }
        public string TipoSeleccion { get; set; }
        public string Estado { get; set; }
        public int? Contador { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
