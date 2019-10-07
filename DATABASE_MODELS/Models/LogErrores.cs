using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogErrores
    {
        public int IdLog { get; set; }
        public int? SessionId { get; set; }
        public DateTime? Fecha { get; set; }
        public string Ip { get; set; }
        public string Pagina { get; set; }
        public string Error { get; set; }
    }
}
