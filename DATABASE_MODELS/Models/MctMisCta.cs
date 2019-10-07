using System;

namespace DATABASE_MODELS.Models
{
    public partial class MctMisCta
    {
        public int CtaId { get; set; }
        public int PersoId { get; set; }
        public int VlcEstadoCta { get; set; }
        public DateTime MctFecha { get; set; }
        public bool? MctAutoregistro { get; set; }

        public virtual CtaCursosTalleres Cta { get; set; }
        public virtual VlcValorCatalogo VlcEstadoCtaNavigation { get; set; }
    }
}
