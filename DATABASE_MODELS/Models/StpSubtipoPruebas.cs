using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class StpSubtipoPruebas
    {
        public StpSubtipoPruebas()
        {
            PrpPruebasProcesos = new HashSet<PrpPruebasProcesos>();
        }

        public int StpId { get; set; }
        public int TipId { get; set; }
        public string StpDescripcion { get; set; }
        public int? IdAgencia { get; set; }

        public virtual ICollection<PrpPruebasProcesos> PrpPruebasProcesos { get; set; }
    }
}
