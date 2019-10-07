using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class AreaOcupacional
    {
        public AreaOcupacional()
        {
            GruposDenominaciones = new HashSet<GruposDenominaciones>();
        }

        public int IdAreaOcupacional { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<GruposDenominaciones> GruposDenominaciones { get; set; }
    }
}
