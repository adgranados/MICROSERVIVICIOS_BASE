using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Publicaciones
    {
        public Publicaciones()
        {
            ProduInterOrgaPublicaciones = new HashSet<ProduInterOrgaPublicaciones>();
        }

        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public string Titulo { get; set; }
        public string EmpreAreaId2 { get; set; }
        public string EmpreAreaId3 { get; set; }
        public string PosiDescrip { get; set; }
        public string Requisitos { get; set; }
        public int? IndId { get; set; }
        public int? SecId { get; set; }
        public string ContraTipoId { get; set; }
        public string EstuNivelId { get; set; }
        public int? SalarioRangoId { get; set; }
        public DateTime? DesdeFecha { get; set; }
        public DateTime? HastaFecha { get; set; }
        public int? AnioExpeDesde { get; set; }
        public int? AnioExpeHasta { get; set; }
        public string PubliSalarioCk { get; set; }
        public int? PubliVigenciaId { get; set; }
        public string PubliEstadoId { get; set; }
        public string ConfiCk { get; set; }
        public string EmpreNombre { get; set; }
        public string CodigoOferta { get; set; }
        public int? PersoidAprobo { get; set; }
        public DateTime? FechaAprob { get; set; }

        public virtual EstuNivel EstuNivel { get; set; }
        public virtual Procesos Procesos { get; set; }
        public virtual PubliEstado PubliEstado { get; set; }
        public virtual SalarioRango SalarioRango { get; set; }
        public virtual ICollection<ProduInterOrgaPublicaciones> ProduInterOrgaPublicaciones { get; set; }
    }
}
