using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class VlcValorCatalogo
    {
        public VlcValorCatalogo()
        {
            CcoPeriodicidadConvocatoria = new HashSet<CcoPeriodicidadConvocatoria>();
            CitCita = new HashSet<CitCita>();
            CnvConvocatoria = new HashSet<CnvConvocatoria>();
            CtaCursosTalleresVlcAreaNavigation = new HashSet<CtaCursosTalleres>();
            CtaCursosTalleresVlcEstadoCuentaNavigation = new HashSet<CtaCursosTalleres>();
            CtaCursosTalleresVlcNivelImparticionNavigation = new HashSet<CtaCursosTalleres>();
            CtaCursosTalleresVlcSubtipoNavigation = new HashSet<CtaCursosTalleres>();
            CtaCursosTalleresVlcTiposCuentaNavigation = new HashSet<CtaCursosTalleres>();
            MctMisCta = new HashSet<MctMisCta>();
            PicPreinscripcionesCta = new HashSet<PicPreinscripcionesCta>();
        }

        public int VlcId { get; set; }
        public string VlcNombre { get; set; }
        public int CtgId { get; set; }

        public virtual CtgCatalogos Ctg { get; set; }
        public virtual ICollection<CcoPeriodicidadConvocatoria> CcoPeriodicidadConvocatoria { get; set; }
        public virtual ICollection<CitCita> CitCita { get; set; }
        public virtual ICollection<CnvConvocatoria> CnvConvocatoria { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleresVlcAreaNavigation { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleresVlcEstadoCuentaNavigation { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleresVlcNivelImparticionNavigation { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleresVlcSubtipoNavigation { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleresVlcTiposCuentaNavigation { get; set; }
        public virtual ICollection<MctMisCta> MctMisCta { get; set; }
        public virtual ICollection<PicPreinscripcionesCta> PicPreinscripcionesCta { get; set; }
    }
}
