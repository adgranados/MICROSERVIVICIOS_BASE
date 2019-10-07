using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ExrExperienciaRango
    {
        public ExrExperienciaRango()
        {
            PrfPreferenciasUsuario = new HashSet<PrfPreferenciasUsuario>();
        }

        public int ExrId { get; set; }
        public string ExrNombre { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }

        public virtual ICollection<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
    }
}
