using System;

namespace DATABASE_MODELS.Models
{
    public partial class AsiAsistencia
    {
        public DateTime IhoFecha { get; set; }
        public int PersoIdOferente { get; set; }
        public bool? AsiAsistio { get; set; }
        public bool? AsiNoAsistio { get; set; }
        public bool? AsiJustifica { get; set; }
        public int CnvId { get; set; }
        public string Estado { get; set; }
    }
}
