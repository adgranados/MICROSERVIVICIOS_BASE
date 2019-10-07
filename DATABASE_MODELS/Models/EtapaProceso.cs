using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EtapaProceso
    {
        public EtapaProceso()
        {
            CandidatosArchivo = new HashSet<CandidatosArchivo>();
        }

        public int IdEtapaProceso { get; set; }
        public string NombreEtapaProceso { get; set; }

        public virtual ICollection<CandidatosArchivo> CandidatosArchivo { get; set; }
    }
}
