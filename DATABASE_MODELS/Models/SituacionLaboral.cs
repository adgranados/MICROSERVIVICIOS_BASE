using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SituacionLaboral
    {
        public SituacionLaboral()
        {
            HvInfoBasica = new HashSet<HvInfoBasica>();
        }

        public int SitLabId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HvInfoBasica> HvInfoBasica { get; set; }
    }
}
