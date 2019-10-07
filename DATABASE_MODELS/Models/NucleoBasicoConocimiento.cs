using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class NucleoBasicoConocimiento
    {
        public NucleoBasicoConocimiento()
        {
            HvEstu = new HashSet<HvEstu>();
        }

        public string IdNucleoConoc { get; set; }
        public string Nombre { get; set; }
        public int? IdAreaDesempeno { get; set; }

        public virtual AreaDesempenio IdAreaDesempenoNavigation { get; set; }
        public virtual ICollection<HvEstu> HvEstu { get; set; }
    }
}
