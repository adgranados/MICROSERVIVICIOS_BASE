using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TpeTipoPeriodoInd
    {
        public TpeTipoPeriodoInd()
        {
            PinPeriodoInd = new HashSet<PinPeriodoInd>();
        }

        public int TpeId { get; set; }
        public string TpeNombre { get; set; }

        public virtual ICollection<PinPeriodoInd> PinPeriodoInd { get; set; }
    }
}
