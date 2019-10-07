using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Acciones
    {
        public Acciones()
        {
            LogAuditoria1 = new HashSet<LogAuditoria1>();
        }

        public int AccionId { get; set; }
        public string NombreAccion { get; set; }

        public virtual ICollection<LogAuditoria1> LogAuditoria1 { get; set; }
    }
}
