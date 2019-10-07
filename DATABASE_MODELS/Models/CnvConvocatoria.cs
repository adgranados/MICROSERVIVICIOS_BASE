using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CnvConvocatoria
    {
        public CnvConvocatoria()
        {
            AocAsistenciaOferenteConvocatoria = new HashSet<AocAsistenciaOferenteConvocatoria>();
            CcoPeriodicidadConvocatoria = new HashSet<CcoPeriodicidadConvocatoria>();
            EvaEvaluacion = new HashSet<EvaEvaluacion>();
            IhoIntensidadHoraria = new HashSet<IhoIntensidadHoraria>();
            InsInscripciones = new HashSet<InsInscripciones>();
        }

        public int CnvId { get; set; }
        public string CnvNombre { get; set; }
        public DateTime CnvFechaCreacion { get; set; }
        public int CnvUsuarioCrea { get; set; }
        public DateTime CnvFechaInscIni { get; set; }
        public DateTime CnvFechaInscFin { get; set; }
        public DateTime CnvFechaEjecIni { get; set; }
        public DateTime CnvFechaEjecFin { get; set; }
        public int CnvCupos { get; set; }
        public int VlcEstadoConvocatoria { get; set; }
        public int CtaId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string CnvDireccion { get; set; }

        public virtual CtaCursosTalleres Cta { get; set; }
        public virtual VlcValorCatalogo VlcEstadoConvocatoriaNavigation { get; set; }
        public virtual ICollection<AocAsistenciaOferenteConvocatoria> AocAsistenciaOferenteConvocatoria { get; set; }
        public virtual ICollection<CcoPeriodicidadConvocatoria> CcoPeriodicidadConvocatoria { get; set; }
        public virtual ICollection<EvaEvaluacion> EvaEvaluacion { get; set; }
        public virtual ICollection<IhoIntensidadHoraria> IhoIntensidadHoraria { get; set; }
        public virtual ICollection<InsInscripciones> InsInscripciones { get; set; }
    }
}
