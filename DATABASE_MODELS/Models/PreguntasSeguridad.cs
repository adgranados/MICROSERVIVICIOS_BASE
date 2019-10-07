using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PreguntasSeguridad
    {
        public PreguntasSeguridad()
        {
            UsrUsuario = new HashSet<UsrUsuario>();
        }

        public int Codpregunta { get; set; }
        public string NombrePregunta { get; set; }

        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
    }
}
