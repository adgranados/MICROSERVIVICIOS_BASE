using System;

namespace DATABASE_MODELS.Models
{
    public partial class PersAreaprof
    {
        public int IdPersona { get; set; }
        public int IdAreaprof { get; set; }
        public int? GradoAreaPers { get; set; }
        public DateTime DtTmst { get; set; }
        public int IdFase { get; set; }
        public string Incrocio { get; set; }
        public string IndStatus { get; set; }
        public string Mensaje { get; set; }
    }
}
