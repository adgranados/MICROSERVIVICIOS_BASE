using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TpsTipoSolicitud
    {
        public TpsTipoSolicitud()
        {
            CtnContactenos = new HashSet<CtnContactenos>();
        }

        public int TpsId { get; set; }
        public string TpsCodigo { get; set; }
        public string TpsNombre { get; set; }

        public virtual ICollection<CtnContactenos> CtnContactenos { get; set; }
    }
}
