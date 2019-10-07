using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CtgCatalogos
    {
        public CtgCatalogos()
        {
            VlcValorCatalogo = new HashSet<VlcValorCatalogo>();
        }

        public int CtgId { get; set; }
        public string CtgNombre { get; set; }
        public string CtgEntidadPadre { get; set; }

        public virtual ICollection<VlcValorCatalogo> VlcValorCatalogo { get; set; }
    }
}
