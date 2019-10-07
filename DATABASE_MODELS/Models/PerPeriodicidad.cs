using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PerPeriodicidad
    {
        public PerPeriodicidad()
        {
            PrfPreferenciasUsuario = new HashSet<PrfPreferenciasUsuario>();
        }

        public int PerId { get; set; }
        public string PerNombre { get; set; }

        public virtual ICollection<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
    }
}
