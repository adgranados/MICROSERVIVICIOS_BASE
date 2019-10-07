using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Funcionalidades
    {
        public Funcionalidades()
        {
            LogAuditoria1 = new HashSet<LogAuditoria1>();
        }

        public int FuncionalidadId { get; set; }
        public string NombreFuncionalidad { get; set; }

        public virtual ICollection<LogAuditoria1> LogAuditoria1 { get; set; }
    }
}
