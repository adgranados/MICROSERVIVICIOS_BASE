using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EstadoCuenta
    {
        public EstadoCuenta()
        {
            SUsuarios = new HashSet<SUsuarios>();
        }

        public int Id { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<SUsuarios> SUsuarios { get; set; }
    }
}
