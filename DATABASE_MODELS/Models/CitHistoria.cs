using System;

namespace DATABASE_MODELS.Models
{
    public partial class CitHistoria
    {
        public int CihId { get; set; }
        public int CitId { get; set; }
        public DateTime Fecha { get; set; }
        public int VlcEstado { get; set; }
    }
}
