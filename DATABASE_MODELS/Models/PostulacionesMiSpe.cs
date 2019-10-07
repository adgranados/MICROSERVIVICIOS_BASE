using System;

namespace DATABASE_MODELS.Models
{
    public partial class PostulacionesMiSpe
    {
        public int Id { get; set; }
        public int SedeId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public DateTime PostuFecha { get; set; }
    }
}
