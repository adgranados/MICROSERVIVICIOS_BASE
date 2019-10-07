using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EstadoNivelEducativo
    {
        public EstadoNivelEducativo()
        {
            HvEstu = new HashSet<HvEstu>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HvEstu> HvEstu { get; set; }
    }
}
