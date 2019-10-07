using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class GruposDenominaciones
    {
        public GruposDenominaciones()
        {
            CargoDetalle = new HashSet<CargoDetalle>();
            HvLaboExpe = new HashSet<HvLaboExpe>();
        }

        public int IdDenominacion { get; set; }
        public int IdAreaOcupacional { get; set; }
        public int IdGrupoOcupacional { get; set; }
        public string GrupoOcupacional { get; set; }
        public string Denominaciones { get; set; }

        public virtual AreaOcupacional IdAreaOcupacionalNavigation { get; set; }
        public virtual ICollection<CargoDetalle> CargoDetalle { get; set; }
        public virtual ICollection<HvLaboExpe> HvLaboExpe { get; set; }
    }
}
