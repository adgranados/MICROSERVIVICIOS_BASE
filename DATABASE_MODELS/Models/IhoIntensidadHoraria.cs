using System;

namespace DATABASE_MODELS.Models
{
    public partial class IhoIntensidadHoraria
    {
        public DateTime IhoFecha { get; set; }
        public TimeSpan IhoHoraInicio { get; set; }
        public TimeSpan IhoHoraFin { get; set; }
        public int CnvId { get; set; }
        public int IhoId { get; set; }

        public virtual CnvConvocatoria Cnv { get; set; }
    }
}
