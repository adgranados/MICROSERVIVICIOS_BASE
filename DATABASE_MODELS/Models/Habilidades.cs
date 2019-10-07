using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Habilidades
    {
        public Habilidades()
        {
            HabiPaisRela = new HashSet<HabiPaisRela>();
        }

        public string HabiId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HabiPaisRela> HabiPaisRela { get; set; }
    }
}
