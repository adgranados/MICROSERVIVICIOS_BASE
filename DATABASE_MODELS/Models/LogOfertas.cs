using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogOfertas
    {
        public int IdLogOfertas { get; set; }
        public DateTime Fecha { get; set; }
        public int ProcesoId { get; set; }
        public int InterOrgaId { get; set; }
        public string Descripcion { get; set; }
        public int Contador { get; set; }
    }
}
