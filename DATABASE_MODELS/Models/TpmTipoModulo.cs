using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TpmTipoModulo
    {
        public TpmTipoModulo()
        {
            PrfPerfiles = new HashSet<PrfPerfiles>();
            UsrUsuario = new HashSet<UsrUsuario>();
        }

        public int TpmId { get; set; }
        public string TpmNombre { get; set; }

        public virtual ICollection<PrfPerfiles> PrfPerfiles { get; set; }
        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
    }
}
