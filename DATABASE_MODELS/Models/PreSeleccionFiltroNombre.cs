namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionFiltroNombre
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int IdBusqueda { get; set; }
        public string Nombre { get; set; }
    }
}
