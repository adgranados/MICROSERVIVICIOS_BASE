using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CgiGrupoIndicador
    {
        public CgiGrupoIndicador()
        {
            CinConceptoIndicador = new HashSet<CinConceptoIndicador>();
        }

        public int CgiId { get; set; }
        public string CgiDescripcion { get; set; }
        public int CgiOrden { get; set; }

        public virtual ICollection<CinConceptoIndicador> CinConceptoIndicador { get; set; }
    }
}
