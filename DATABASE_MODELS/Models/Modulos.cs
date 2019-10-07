using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Modulos
    {
        public Modulos()
        {
            LogAuditoria1 = new HashSet<LogAuditoria1>();
        }

        public int ModuloId { get; set; }
        public string NombreModulo { get; set; }

        public virtual ICollection<LogAuditoria1> LogAuditoria1 { get; set; }
    }
}
