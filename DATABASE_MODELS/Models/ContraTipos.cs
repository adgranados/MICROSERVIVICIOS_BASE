using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ContraTipos
    {
        public ContraTipos()
        {
            PrfPreferenciasUsuario = new HashSet<PrfPreferenciasUsuario>();
        }

        public string ContraTipoId { get; set; }
        public string Nombre { get; set; }
        public string CodSispe { get; set; }

        public virtual ICollection<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
    }
}
