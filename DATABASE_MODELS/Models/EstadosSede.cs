using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EstadosSede
    {
        public EstadosSede()
        {
            Sedes = new HashSet<Sedes>();
        }

        public int Idestado { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Sedes> Sedes { get; set; }
    }
}
