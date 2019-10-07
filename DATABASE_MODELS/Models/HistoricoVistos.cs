using System;

namespace DATABASE_MODELS.Models
{
    public partial class HistoricoVistos
    {
        public int Id { get; set; }
        public int AgentePersoId { get; set; }
        public DateTime Fecha { get; set; }
        public int IdVisto { get; set; }

        public virtual MatchingVistos IdVistoNavigation { get; set; }
    }
}
