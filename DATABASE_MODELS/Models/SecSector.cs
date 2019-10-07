using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SecSector
    {
        public SecSector()
        {
            ActActividad = new HashSet<ActActividad>();
        }

        public int SecId { get; set; }
        public int SecCodigo { get; set; }
        public string SecNombre { get; set; }
        public int IndId { get; set; }

        public virtual IndIndustria Ind { get; set; }
        public virtual ICollection<ActActividad> ActActividad { get; set; }
    }
}
