using System;

namespace DATABASE_MODELS.Models
{
    public partial class TarTarifa
    {
        public int TarId { get; set; }
        public int TarRangoIni { get; set; }
        public decimal TarValor { get; set; }
        public bool? TarActivo { get; set; }
        public int TarRangoFin { get; set; }
        public DateTime? TarVigenciaIni { get; set; }
        public DateTime? TarVigenciaFin { get; set; }
    }
}
