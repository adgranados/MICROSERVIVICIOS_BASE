namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionCriterios
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public string Filtro { get; set; }
        public string CampoOrden { get; set; }
        public string Direccion { get; set; }
        public int? Paginas { get; set; }
        public int? IdBusqueda { get; set; }
        public int? SalarioRangoId { get; set; }
        public string CargoId { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string PaginaDesde { get; set; }
    }
}
