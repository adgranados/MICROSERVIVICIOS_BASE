using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EmpreIndus
    {
        public EmpreIndus()
        {
            EmpreIndusPaisRela = new HashSet<EmpreIndusPaisRela>();
            EmpreSector = new HashSet<EmpreSector>();
        }

        public string EmpreIndusId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<EmpreIndusPaisRela> EmpreIndusPaisRela { get; set; }
        public virtual ICollection<EmpreSector> EmpreSector { get; set; }
    }
}
