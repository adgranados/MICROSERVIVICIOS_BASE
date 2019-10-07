using System;

namespace DATABASE_MODELS.Models
{
    public partial class CitCita
    {
        public int CitId { get; set; }
        public int PersoIdOferente { get; set; }
        public DateTime CitFechaSolicitud { get; set; }
        public int PersoIdGestiona { get; set; }
        public int VlcEstadoCita { get; set; }
        public DateTime? CitFechaEjecucion { get; set; }
        public int? CtaId { get; set; }
        public bool CitAutoSolicitud { get; set; }
        public int? PersoIdReco { get; set; }
        public int? EvaId { get; set; }
        public int? CnvId { get; set; }

        public virtual Personas PersoIdOferenteNavigation { get; set; }
        public virtual VlcValorCatalogo VlcEstadoCitaNavigation { get; set; }
    }
}
