using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class MotivoCierreCta
    {
        public MotivoCierreCta()
        {
            SUsuarios = new HashSet<SUsuarios>();
            Sedes = new HashSet<Sedes>();
        }

        public int MotivoCierreId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<SUsuarios> SUsuarios { get; set; }
        public virtual ICollection<Sedes> Sedes { get; set; }
    }
}
