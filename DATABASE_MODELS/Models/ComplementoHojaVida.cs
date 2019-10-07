using System;

namespace DATABASE_MODELS.Models
{
    public partial class ComplementoHojaVida
    {
        public int ComplementoHojaVidaId { get; set; }
        public int PersoId { get; set; }
        public int? ProgramaGobiernoId { get; set; }
        public DateTime FechaVinculacion { get; set; }
        public int? AgenciaIdVinculacion { get; set; }

        public virtual ProgramaXgobierno ProgramaGobierno { get; set; }
    }
}
