using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class IndicadoresTotalesPorGrupo
    {
        public IndicadoresTotalesPorGrupo()
        {
            HistIndicaTotales = new HashSet<HistIndicaTotales>();
            HistIndicaTotalesOferentes = new HashSet<HistIndicaTotalesOferentes>();
            HistIndicaTotalesRemitidos = new HashSet<HistIndicaTotalesRemitidos>();
            HistIndicador40Mil = new HashSet<HistIndicador40Mil>();
            HistIndicadorDiscap = new HashSet<HistIndicadorDiscap>();
            HistIndicadorVictima = new HashSet<HistIndicadorVictima>();
        }

        public int Id { get; set; }
        public string Indicador { get; set; }
        public int IdGrupo { get; set; }

        public virtual GrupoReportes IdGrupoNavigation { get; set; }
        public virtual ICollection<HistIndicaTotales> HistIndicaTotales { get; set; }
        public virtual ICollection<HistIndicaTotalesOferentes> HistIndicaTotalesOferentes { get; set; }
        public virtual ICollection<HistIndicaTotalesRemitidos> HistIndicaTotalesRemitidos { get; set; }
        public virtual ICollection<HistIndicador40Mil> HistIndicador40Mil { get; set; }
        public virtual ICollection<HistIndicadorDiscap> HistIndicadorDiscap { get; set; }
        public virtual ICollection<HistIndicadorVictima> HistIndicadorVictima { get; set; }
    }
}
