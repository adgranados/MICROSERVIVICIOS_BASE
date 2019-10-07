using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProcesosSectorHidrocarburos
    {
        public ProcesosSectorHidrocarburos()
        {
            Procesos = new HashSet<Procesos>();
            ProcesosSubsectorHidrocarburos = new HashSet<ProcesosSubsectorHidrocarburos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Procesos> Procesos { get; set; }
        public virtual ICollection<ProcesosSubsectorHidrocarburos> ProcesosSubsectorHidrocarburos { get; set; }
    }
}
