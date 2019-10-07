using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvIdioArchivo
    {
        public int PersoId { get; set; }
        public string IdioId { get; set; }
        public int Nivel { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string OtroIdioma { get; set; }
        public int Id { get; set; }
    }
}
