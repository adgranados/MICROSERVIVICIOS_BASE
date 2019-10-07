using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class MotivoCambioPrestadorSede
    {
        public MotivoCambioPrestadorSede()
        {
            SedesAgenciaHistorico = new HashSet<SedesAgenciaHistorico>();
        }

        public int IdMotivo { get; set; }
        public string DescripcionMotivo { get; set; }
        public string TipoMotivo { get; set; }

        public virtual ICollection<SedesAgenciaHistorico> SedesAgenciaHistorico { get; set; }
    }
}
