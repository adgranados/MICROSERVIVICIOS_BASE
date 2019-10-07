using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProcesosSubsectorHidrocarburos
    {
        public ProcesosSubsectorHidrocarburos()
        {
            Procesos = new HashSet<Procesos>();
        }

        public int Id { get; set; }
        public int SectorId { get; set; }
        public string Nombre { get; set; }

        public virtual ProcesosSectorHidrocarburos Sector { get; set; }
        public virtual ICollection<Procesos> Procesos { get; set; }
    }
}
