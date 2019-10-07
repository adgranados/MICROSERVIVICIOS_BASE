using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class AreaDesempenio
    {
        public AreaDesempenio()
        {
            HvEstu = new HashSet<HvEstu>();
            NucleoBasicoConocimiento = new HashSet<NucleoBasicoConocimiento>();
        }

        public int IdAreaDesempeno { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HvEstu> HvEstu { get; set; }
        public virtual ICollection<NucleoBasicoConocimiento> NucleoBasicoConocimiento { get; set; }
    }
}
