using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TipoCorreos
    {
        public TipoCorreos()
        {
            AdminCorreos = new HashSet<AdminCorreos>();
        }

        public int IdTipocorreo { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AdminCorreos> AdminCorreos { get; set; }
    }
}
