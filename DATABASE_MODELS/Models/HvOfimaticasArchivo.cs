using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvOfimaticasArchivo
    {
        public int PersoId { get; set; }
        public int OfiId { get; set; }
        public int Nivel { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string OfiTipoDesc { get; set; }
        public int OfimaticaId { get; set; }
    }
}
