using System;

namespace DATABASE_MODELS.Models
{
    public partial class OriDescartes
    {
        public int DescarteId { get; set; }
        public int PersoId { get; set; }
        public int CnvId { get; set; }
        public int CtaId { get; set; }
        public DateTime FechaDescarte { get; set; }
    }
}
