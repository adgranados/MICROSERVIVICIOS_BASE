using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CdcCausalesDescarte
    {
        public CdcCausalesDescarte()
        {
            PcdProcesoCausalDescarte = new HashSet<PcdProcesoCausalDescarte>();
        }

        public int CdcId { get; set; }
        public string CdcNombre { get; set; }
        public bool CdcActiva { get; set; }
        public string CdcTipo { get; set; }
        public bool? CdcNoseleccionadoVnormal { get; set; }
        public bool? CdcNoseleccionadoVhidro { get; set; }

        public virtual ICollection<PcdProcesoCausalDescarte> PcdProcesoCausalDescarte { get; set; }
    }
}
