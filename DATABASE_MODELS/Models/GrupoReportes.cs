using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class GrupoReportes
    {
        public GrupoReportes()
        {
            IndicadoresTotalesPorGrupo = new HashSet<IndicadoresTotalesPorGrupo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<IndicadoresTotalesPorGrupo> IndicadoresTotalesPorGrupo { get; set; }
    }
}
