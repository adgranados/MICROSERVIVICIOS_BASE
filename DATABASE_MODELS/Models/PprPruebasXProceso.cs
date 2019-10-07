using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PprPruebasXProceso
    {
        public PprPruebasXProceso()
        {
            UppUsuarioPruebasProceso = new HashSet<UppUsuarioPruebasProceso>();
        }

        public int PprId { get; set; }
        public int ProcesoId { get; set; }
        public int PrpId { get; set; }
        public int InterOrgaId { get; set; }

        public virtual PrpPruebasProcesos Prp { get; set; }
        public virtual ICollection<UppUsuarioPruebasProceso> UppUsuarioPruebasProceso { get; set; }
    }
}
