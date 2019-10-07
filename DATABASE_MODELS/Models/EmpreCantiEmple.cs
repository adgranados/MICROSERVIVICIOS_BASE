using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EmpreCantiEmple
    {
        public EmpreCantiEmple()
        {
            InterOrga = new HashSet<InterOrga>();
        }

        public int CantiEmpleId { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }

        public virtual ICollection<InterOrga> InterOrga { get; set; }
    }
}
