using System;

namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionBusquedas
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public int IdBusqueda { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public string BusquedaActual { get; set; }
        public string Tipo { get; set; }
    }
}
