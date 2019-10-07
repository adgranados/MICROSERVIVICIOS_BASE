using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EmpreNaturaleza
    {
        public EmpreNaturaleza()
        {
            InterOrga = new HashSet<InterOrga>();
        }

        public int IdNaturaleza { get; set; }
        public string Naturaleza { get; set; }

        public virtual ICollection<InterOrga> InterOrga { get; set; }
    }
}
