using System;

namespace DATABASE_MODELS.Models
{
    public partial class AucAuditCursosTalleres
    {
        public int AucId { get; set; }
        public int? AucIdAnterior { get; set; }
        public DateTime AucFechaCambio { get; set; }
        public string AucTipMov { get; set; }
        public int CtaId { get; set; }
        public int VlcEstadoCuenta { get; set; }
        public DateTime CtaFechaCreacion { get; set; }
        public int CtaUsurioCrea { get; set; }
        public int? CtaUsuUltModif { get; set; }
        public DateTime? CtaFechaUltModif { get; set; }
    }
}
