using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CtaCursosTalleres
    {
        public CtaCursosTalleres()
        {
            CnvConvocatoria = new HashSet<CnvConvocatoria>();
            InsInscripciones = new HashSet<InsInscripciones>();
            MctMisCta = new HashSet<MctMisCta>();
            PicPreinscripcionesCta = new HashSet<PicPreinscripcionesCta>();
        }

        public int CtaId { get; set; }
        public string CtaNombre { get; set; }
        public string CtaDescripcion { get; set; }
        public int VlcArea { get; set; }
        public string CtaAdjunto { get; set; }
        public int VlcTiposCuenta { get; set; }
        public DateTime CtaFechaCreacion { get; set; }
        public int AgenciaId { get; set; }
        public int VlcSubtipo { get; set; }
        public string CtaReqAcceso { get; set; }
        public string CtaReqAprob { get; set; }
        public int CtaUsurioCrea { get; set; }
        public int? CtaUsuUltModif { get; set; }
        public DateTime? CtaFechaUltModif { get; set; }
        public string CtaModulos { get; set; }
        public string CtaOcupTrabRel { get; set; }
        public string CtaPerfiles { get; set; }
        public string CtaLugarImpartic { get; set; }
        public bool CtaCertificado { get; set; }
        public int CtaCupos { get; set; }
        public int CtaHoras { get; set; }
        public bool CtaPublico { get; set; }
        public bool CtaPeriodicidad { get; set; }
        public int VlcEstadoCuenta { get; set; }
        public int VlcNivelImparticion { get; set; }
        public bool? CtaReqiereAsis { get; set; }
        public int? CtaPorcentajeAsis { get; set; }
        public string CtaTitulo { get; set; }
        public string CtaCodigo { get; set; }
        public int? EntId { get; set; }
        public string CtaCompetencia { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string EntidadImparte { get; set; }
        public bool? CtaTercero { get; set; }
        public bool? CtaEsEmprendi { get; set; }
        public bool? SegMensual { get; set; }

        public virtual Agencia Agencia { get; set; }
        public virtual VlcValorCatalogo VlcAreaNavigation { get; set; }
        public virtual VlcValorCatalogo VlcEstadoCuentaNavigation { get; set; }
        public virtual VlcValorCatalogo VlcNivelImparticionNavigation { get; set; }
        public virtual VlcValorCatalogo VlcSubtipoNavigation { get; set; }
        public virtual VlcValorCatalogo VlcTiposCuentaNavigation { get; set; }
        public virtual ICollection<CnvConvocatoria> CnvConvocatoria { get; set; }
        public virtual ICollection<InsInscripciones> InsInscripciones { get; set; }
        public virtual ICollection<MctMisCta> MctMisCta { get; set; }
        public virtual ICollection<PicPreinscripcionesCta> PicPreinscripcionesCta { get; set; }
    }
}
