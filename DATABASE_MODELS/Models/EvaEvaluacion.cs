using System;

namespace DATABASE_MODELS.Models
{
    public partial class EvaEvaluacion
    {
        public int EvaId { get; set; }
        public DateTime EvaFechaEval { get; set; }
        public string EvaObservaciones { get; set; }
        public int PersoIdEvaluador { get; set; }
        public int CnvId { get; set; }
        public int PersoIdOferente { get; set; }
        public bool EvaAprobo { get; set; }
        public string EvaRutaCertificado { get; set; }

        public virtual CnvConvocatoria Cnv { get; set; }
        public virtual PersonasAgencia PersoIdEvaluadorNavigation { get; set; }
        public virtual Personas PersoIdOferenteNavigation { get; set; }
    }
}
