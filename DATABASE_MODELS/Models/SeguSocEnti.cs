using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SeguSocEnti
    {
        public SeguSocEnti()
        {
            HvSeguSocCesantEnti = new HashSet<HvSeguSoc>();
            HvSeguSocCompenEnti = new HashSet<HvSeguSoc>();
            HvSeguSocPensoEnti = new HashSet<HvSeguSoc>();
            HvSeguSocPensvEnti = new HashSet<HvSeguSoc>();
        }

        public string EntiId { get; set; }
        public string Nombre { get; set; }
        public string TipoEntiId { get; set; }

        public virtual SeguSocTipoEnti TipoEnti { get; set; }
        public virtual ICollection<HvSeguSoc> HvSeguSocCesantEnti { get; set; }
        public virtual ICollection<HvSeguSoc> HvSeguSocCompenEnti { get; set; }
        public virtual ICollection<HvSeguSoc> HvSeguSocPensoEnti { get; set; }
        public virtual ICollection<HvSeguSoc> HvSeguSocPensvEnti { get; set; }
    }
}
