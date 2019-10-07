using System;

namespace DATABASE_MODELS.Models
{
    public partial class CepColectivosEspPersona
    {
        public int CesId { get; set; }
        public int PersoId { get; set; }
        public DateTime? FechaCertificacion { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string CesPaisRetornado { get; set; }

        public virtual CesColectivosEsp Ces { get; set; }
        public virtual Personas Perso { get; set; }
    }
}
