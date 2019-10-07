using System;

namespace DATABASE_MODELS.Models
{
    public partial class FfaFosfecCriteriosAudit
    {
        public int FfaId { get; set; }
        public int FfdId { get; set; }
        public string FfaCriterio { get; set; }
        public string FfaValor { get; set; }
        public DateTime FfaFecha { get; set; }
        public string FfaJustificacion { get; set; }
        public int PersoIdAgente { get; set; }

        public virtual FfdFosfecDetalleVersion Ffd { get; set; }
        public virtual PersonasAgencia PersoIdAgenteNavigation { get; set; }
    }
}
