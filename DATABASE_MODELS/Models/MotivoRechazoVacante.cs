using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class MotivoRechazoVacante
    {
        public MotivoRechazoVacante()
        {
            Procesos = new HashSet<Procesos>();
        }

        public int IdMotivoRechazo { get; set; }
        public string DescripcionMotivo { get; set; }

        public virtual ICollection<Procesos> Procesos { get; set; }
    }
}
