using System;

namespace DATABASE_MODELS.Models
{
    public partial class CepColectivosEspPersonaArchivo
    {
        public int CesId { get; set; }
        public int PersoId { get; set; }
        public DateTime? FechaCertificacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int Id { get; set; }
    }
}
