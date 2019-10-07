using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TipoExperienciaLaboral
    {
        public TipoExperienciaLaboral()
        {
            HvLaboExpe = new HashSet<HvLaboExpe>();
        }

        public int IdTipoExperienciaLaboral { get; set; }
        public string NombreTipoExperienciaLaboral { get; set; }

        public virtual ICollection<HvLaboExpe> HvLaboExpe { get; set; }
    }
}
