using System;

namespace DATABASE_MODELS.Models
{
    public partial class HistPostuOferente
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public short EscId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdAgenciaEscId { get; set; }
        public int? AsesorId { get; set; }

        public virtual Postulaciones Pos { get; set; }
    }
}
