using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class IndIndustria
    {
        public IndIndustria()
        {
            ActActividad = new HashSet<ActActividad>();
            SecSector = new HashSet<SecSector>();
        }

        public int IndId { get; set; }
        public string IndCodigo { get; set; }
        public string IndNombre { get; set; }

        public virtual ICollection<ActActividad> ActActividad { get; set; }
        public virtual ICollection<SecSector> SecSector { get; set; }
    }
}
