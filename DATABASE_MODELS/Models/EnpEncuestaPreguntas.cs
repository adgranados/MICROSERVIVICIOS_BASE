using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EnpEncuestaPreguntas
    {
        public EnpEncuestaPreguntas()
        {
            PesProcesoEncuestaSatisfaccion = new HashSet<PesProcesoEncuestaSatisfaccion>();
        }

        public int EnpId { get; set; }
        public string Pregunta { get; set; }

        public virtual ICollection<PesProcesoEncuestaSatisfaccion> PesProcesoEncuestaSatisfaccion { get; set; }
    }
}
