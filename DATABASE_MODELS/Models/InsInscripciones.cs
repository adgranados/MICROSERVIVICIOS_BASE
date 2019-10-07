using System;

namespace DATABASE_MODELS.Models
{
    public partial class InsInscripciones
    {
        public int InsId { get; set; }
        public int PicId { get; set; }
        public DateTime InsFecha { get; set; }
        public int PersoIdAgencia { get; set; }
        public DateTime InsFechaAccion { get; set; }
        public string InsLugarAccion { get; set; }
        public int CtaId { get; set; }
        public int PersoIdOferente { get; set; }
        public int VlcEstadoInscrip { get; set; }
        public string InsDetalleFinal { get; set; }
        public int CnvId { get; set; }

        public virtual CnvConvocatoria Cnv { get; set; }
        public virtual CtaCursosTalleres Cta { get; set; }
        public virtual PersonasAgencia PersoIdAgenciaNavigation { get; set; }
        public virtual Personas PersoIdOferenteNavigation { get; set; }
        public virtual PicPreinscripcionesCta Pic { get; set; }
    }
}
