using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProduInterOrga
    {
        public ProduInterOrga()
        {
            ProduInterOrgaPublicaciones = new HashSet<ProduInterOrgaPublicaciones>();
        }

        public int InterOrgaId { get; set; }
        public int ProduId { get; set; }
        public int ProduOr { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string ProduEstaId { get; set; }
        public int? CantHv { get; set; }
        public int? CantClasificados { get; set; }

        public virtual InterOrga InterOrga { get; set; }
        public virtual Producto Produ { get; set; }
        public virtual ProductoEstado ProduEsta { get; set; }
        public virtual ICollection<ProduInterOrgaPublicaciones> ProduInterOrgaPublicaciones { get; set; }
    }
}
