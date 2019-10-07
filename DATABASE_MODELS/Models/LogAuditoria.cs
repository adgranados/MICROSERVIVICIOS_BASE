using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogAuditoria
    {
        public int IdOperacion { get; set; }
        public int PersoId { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string NombreProceso { get; set; }
        public string NombreOpercion { get; set; }
        public string NombreTabla { get; set; }
        public int RolId { get; set; }
        public string Sentencia { get; set; }
    }
}
