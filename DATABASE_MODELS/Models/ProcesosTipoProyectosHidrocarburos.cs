using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProcesosTipoProyectosHidrocarburos
    {
        public ProcesosTipoProyectosHidrocarburos()
        {
            Procesos = new HashSet<Procesos>();
        }

        public int Id { get; set; }
        public string Detalle { get; set; }

        public virtual ICollection<Procesos> Procesos { get; set; }
    }
}
