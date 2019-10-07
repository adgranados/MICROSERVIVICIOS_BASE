using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Idiomas
    {
        public Idiomas()
        {
            HvIdio = new HashSet<HvIdio>();
        }

        public string IdioId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HvIdio> HvIdio { get; set; }
    }
}
