using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PicPreinscripcionesCta
    {
        public PicPreinscripcionesCta()
        {
            InsInscripciones = new HashSet<InsInscripciones>();
        }

        public int PicId { get; set; }
        public int CtaId { get; set; }
        public DateTime PicFechaPreinsc { get; set; }
        public int VlcEstadoPreinsc { get; set; }
        public string PicObservaciones { get; set; }
        public int PersoIdOferente { get; set; }
        public bool? PicAutoregistro { get; set; }
        public int CnvId { get; set; }
        public DateTime? PicFechaReco { get; set; }
        public int? PersoIdReco { get; set; }

        public virtual CtaCursosTalleres Cta { get; set; }
        public virtual Personas PersoIdOferenteNavigation { get; set; }
        public virtual VlcValorCatalogo VlcEstadoPreinscNavigation { get; set; }
        public virtual ICollection<InsInscripciones> InsInscripciones { get; set; }
    }
}
