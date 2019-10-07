using System;

namespace DATABASE_MODELS.Models
{
    public partial class ProgramaXProcesoYSede
    {
        public int ProcesoId { get; set; }
        public int SedeId { get; set; }
        public int ProgramaId { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }
        public DateTime? FechaMarcado { get; set; }
    }
}
