namespace DATABASE_MODELS.Models
{
    public partial class IndIndicador
    {
        public int IndId { get; set; }
        public string IndDescripcion { get; set; }
        public string IndMetrica { get; set; }
        public int IndOrden { get; set; }
        public int CinId { get; set; }

        public virtual CinConceptoIndicador Cin { get; set; }
    }
}
