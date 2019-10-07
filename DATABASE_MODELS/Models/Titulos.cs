using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Titulos
    {
        public Titulos()
        {
            HvEstuTitu = new HashSet<HvEstu>();
            HvEstuTituEquivNavigation = new HashSet<HvEstu>();
        }

        public string TituId { get; set; }
        public string Nombre { get; set; }
        public string EstuNivelId { get; set; }
        public string IdNucleoConoc { get; set; }

        public virtual EstuNivel EstuNivel { get; set; }
        public virtual ICollection<HvEstu> HvEstuTitu { get; set; }
        public virtual ICollection<HvEstu> HvEstuTituEquivNavigation { get; set; }
    }
}
