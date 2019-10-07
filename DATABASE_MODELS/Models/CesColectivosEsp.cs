using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class CesColectivosEsp
    {
        public CesColectivosEsp()
        {
            CepColectivosEspPersona = new HashSet<CepColectivosEspPersona>();
        }

        public int CesId { get; set; }
        public string CesNombre { get; set; }
        public int? CesOrden { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<CepColectivosEspPersona> CepColectivosEspPersona { get; set; }
    }
}
