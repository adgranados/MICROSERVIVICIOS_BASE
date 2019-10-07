using System;

namespace DATABASE_MODELS.Models
{
    public partial class HistEstadoVacante
    {
        public int Id { get; set; }
        public int SedeId { get; set; }
        public int ProcesoId { get; set; }
        public string ProceEstaId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
