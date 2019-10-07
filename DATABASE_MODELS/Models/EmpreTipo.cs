using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EmpreTipo
    {
        public EmpreTipo()
        {
            InterOrga = new HashSet<InterOrga>();
        }

        public string EmpreTipoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<InterOrga> InterOrga { get; set; }
    }
}
