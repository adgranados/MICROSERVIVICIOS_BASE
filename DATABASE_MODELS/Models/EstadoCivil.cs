using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Personas = new HashSet<Personas>();
        }

        public int IdEstadoCivil { get; set; }
        public string NomEstadoCivil { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
