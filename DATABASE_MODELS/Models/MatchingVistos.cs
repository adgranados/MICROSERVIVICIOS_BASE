using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class MatchingVistos
    {
        public MatchingVistos()
        {
            HistoricoVistos = new HashSet<HistoricoVistos>();
        }

        public int IdVisto { get; set; }
        public int SedeId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }

        public virtual ICollection<HistoricoVistos> HistoricoVistos { get; set; }
    }
}
