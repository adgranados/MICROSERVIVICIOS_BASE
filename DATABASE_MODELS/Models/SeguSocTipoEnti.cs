using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SeguSocTipoEnti
    {
        public SeguSocTipoEnti()
        {
            SeguSocEnti = new HashSet<SeguSocEnti>();
        }

        public string TipoEntiId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<SeguSocEnti> SeguSocEnti { get; set; }
    }
}
