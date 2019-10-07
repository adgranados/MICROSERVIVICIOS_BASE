using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class UpeUsuarioPruebasEval
    {
        public UpeUsuarioPruebasEval()
        {
            UppUsuarioPruebasProceso = new HashSet<UppUsuarioPruebasProceso>();
        }

        public int UpeId { get; set; }
        public int UprId { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaEval { get; set; }
        public int PersoIdAgente { get; set; }

        public virtual PersonasAgencia PersoIdAgenteNavigation { get; set; }
        public virtual UprUsuarioPruebas Upr { get; set; }
        public virtual ICollection<UppUsuarioPruebasProceso> UppUsuarioPruebasProceso { get; set; }
    }
}
