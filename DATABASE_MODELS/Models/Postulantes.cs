using System;

namespace DATABASE_MODELS.Models
{
    public partial class Postulantes
    {
        public int PersoId { get; set; }
        public DateTime? IniFecha { get; set; }
        public int? PersoIdAsesor { get; set; }

        public virtual Personas Perso { get; set; }
    }
}
