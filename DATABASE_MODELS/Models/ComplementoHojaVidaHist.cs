using System;

namespace DATABASE_MODELS.Models
{
    public partial class ComplementoHojaVidaHist
    {
        public int ComplementoHojaVidaHistId { get; set; }
        public int PersoId { get; set; }
        public int? ProgramaGobiernoId { get; set; }
        public DateTime FechaVinculacion { get; set; }
        public int? AgenciaIdVinculacion { get; set; }
        public bool? Marcado { get; set; }
        public int? PersoIdAsesor { get; set; }
        public bool Automatico { get; set; }

        public virtual ProgramaXgobierno ProgramaGobierno { get; set; }
    }
}
