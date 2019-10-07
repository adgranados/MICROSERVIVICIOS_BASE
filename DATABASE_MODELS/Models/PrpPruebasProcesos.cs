using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PrpPruebasProcesos
    {
        public PrpPruebasProcesos()
        {
            PprPruebasXProceso = new HashSet<PprPruebasXProceso>();
            UprUsuarioPruebas = new HashSet<UprUsuarioPruebas>();
        }

        public int PrpId { get; set; }
        public int StpId { get; set; }
        public string PrpNombre { get; set; }
        public string PrpDescripcion { get; set; }
        public string PrpComentarios { get; set; }
        public DateTime PrpFechaCrea { get; set; }
        public int PersoIdCre { get; set; }
        public DateTime? PrpFechaMod { get; set; }
        public int? PersoIdMod { get; set; }
        public int? IdAgencia { get; set; }
        public int? PrpEstado { get; set; }
        public string PrpFile { get; set; }

        public virtual StpSubtipoPruebas Stp { get; set; }
        public virtual ICollection<PprPruebasXProceso> PprPruebasXProceso { get; set; }
        public virtual ICollection<UprUsuarioPruebas> UprUsuarioPruebas { get; set; }
    }
}
