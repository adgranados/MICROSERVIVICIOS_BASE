using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ClasePrestador
    {
        public ClasePrestador()
        {
            EntEntidad = new HashSet<EntEntidad>();
        }

        public int ClaseId { get; set; }
        public string ClasePrestador1 { get; set; }

        public virtual ICollection<EntEntidad> EntEntidad { get; set; }
    }
}
