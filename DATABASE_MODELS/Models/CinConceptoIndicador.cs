using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CinConceptoIndicador
    {
        public CinConceptoIndicador()
        {
            IndIndicador = new HashSet<IndIndicador>();
        }

        public int CinId { get; set; }
        public int CgiId { get; set; }
        public string CinDescripcion { get; set; }
        public int CinOrden { get; set; }

        public virtual CgiGrupoIndicador Cgi { get; set; }
        public virtual ICollection<IndIndicador> IndIndicador { get; set; }
    }
}
