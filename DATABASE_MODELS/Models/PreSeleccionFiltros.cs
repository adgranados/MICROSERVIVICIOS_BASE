namespace DATABASE_MODELS.Models
{
    public partial class PreSeleccionFiltros
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int FiltroOr { get; set; }
        public string Campo { get; set; }
        public string Filtro1 { get; set; }
        public string Filtro2 { get; set; }
        public string Filtro3 { get; set; }
        public string Filtro4 { get; set; }
        public string Filtro5 { get; set; }
        public string Filtro6 { get; set; }
        public string FormuCodi { get; set; }
        public string FiltroDescrip { get; set; }
        public int? Puntaje { get; set; }

        public virtual Procesos Procesos { get; set; }
    }
}
