namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionFiltroAnosDeExperiencia
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int IdBusqueda { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
    }
}
