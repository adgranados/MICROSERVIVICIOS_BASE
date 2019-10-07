using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProceEstado
    {
        public ProceEstado()
        {
            Procesos = new HashSet<Procesos>();
        }

        public string ProceEstaId { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }

        public virtual ICollection<Procesos> Procesos { get; set; }
    }
}
