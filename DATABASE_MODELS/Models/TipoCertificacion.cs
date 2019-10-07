using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TipoCertificacion
    {
        public TipoCertificacion()
        {
            HvCurso = new HashSet<HvCurso>();
        }

        public int IdTipoCertificado { get; set; }
        public string NombreTipoCertificado { get; set; }

        public virtual ICollection<HvCurso> HvCurso { get; set; }
    }
}
