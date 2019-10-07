namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionFiltroIdiomas
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int IdBusqueda { get; set; }
        public string IdioId { get; set; }
        public int? NivelValor { get; set; }
    }
}
