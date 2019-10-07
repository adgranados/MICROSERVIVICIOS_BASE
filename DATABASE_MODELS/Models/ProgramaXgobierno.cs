using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProgramaXgobierno
    {
        public ProgramaXgobierno()
        {
            ComplementoHojaVida = new HashSet<ComplementoHojaVida>();
            ComplementoHojaVidaHist = new HashSet<ComplementoHojaVidaHist>();
        }

        public int ProgramasGobiernoId { get; set; }
        public string NombreProgramas { get; set; }
        public bool? Matching { get; set; }
        public bool? Oferentes { get; set; }
        public bool? Vacantes { get; set; }

        public virtual ICollection<ComplementoHojaVida> ComplementoHojaVida { get; set; }
        public virtual ICollection<ComplementoHojaVidaHist> ComplementoHojaVidaHist { get; set; }
    }
}
