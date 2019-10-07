using System;

namespace DATABASE_MODELS.Models
{
    public partial class FfcCargue
    {
        public int FfcCargueId { get; set; }
        public int EntId { get; set; }
        public string FfvVersion { get; set; }
        public int FfvMes { get; set; }
        public string FfvAnio { get; set; }
        public bool FfcEstado { get; set; }
        public DateTime FfcFechaCargue { get; set; }
        public string FfcUsuarioCargue { get; set; }
    }
}
